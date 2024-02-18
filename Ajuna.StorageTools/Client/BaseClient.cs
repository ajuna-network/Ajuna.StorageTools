﻿using Substrate.NET.Schnorrkel.Keys;
using Serilog;
using StreamJsonRpc;
using Substrate.Bajun.NET.NetApiExt.Generated;
using Substrate.Bajun.NET.NetApiExt.Generated.Model.frame_system;
using Substrate.Bajun.NET.NetApiExt.Generated.Storage;
using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Types;
using System.Text;
using Substrate.Integration.Client;
using Substrate.Integration.Helper;
using Substrate.NetApi.Model.Rpc;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;
using System.ComponentModel.Design;

namespace Ajuna.StorageTools.Client
{
    public class BaseClient
    {
        private readonly int _maxConcurrentCalls;

        private readonly ChargeType _chargeTypeDefault;

        private static MiniSecret MiniSecretAlice => new MiniSecret(Utils.HexToByteArray("0xe5be9a5092b81bca64be81d212e7f2f9eba183bb7a90954f7b76361f6edb5c0a"), ExpandMode.Ed25519);

        /// <summary>
        /// Alice account
        /// </summary>
        public static Account Alice => Account.Build(KeyType.Sr25519, MiniSecretAlice.ExpandToSecret().ToEd25519Bytes(), MiniSecretAlice.GetPair().Public.Key);

        /// <summary>
        /// Extrinsic manager, used to manage extrinsic subscriptions and the corresponding states.
        /// </summary>
        public ExtrinsicManager ExtrinsicManager { get; }

        /// <summary>
        /// Subscription manager, used to manage subscriptions of storage elements.
        /// </summary>
        public SubscriptionManager SubscriptionManager { get; }

        /// <summary>
        /// Substrate Extension Client
        /// </summary>
        public SubstrateClientExt SubstrateClient { get; }

        /// <summary>
        /// Is connected to the network
        /// </summary>
        public bool IsConnected => SubstrateClient.IsConnected;

        /// <summary>
        /// Network type
        /// </summary>
        public NetworkType NetworkType { get; set; }

        /// <summary>
        /// Base Client Constructor
        /// </summary>
        /// <param name="url"></param>
        /// <param name="networkType"></param>
        /// <param name="maxConcurrentCalls"></param>
        public BaseClient(string url, NetworkType networkType, int maxConcurrentCalls = 10)
        {
            if (networkType == NetworkType.Host || networkType == NetworkType.Test)
            {
                _chargeTypeDefault = ChargeAssetTxPayment.Default();
            }
            else
            {
                _chargeTypeDefault = ChargeTransactionPayment.Default();
            }

            _maxConcurrentCalls = maxConcurrentCalls;

            SubstrateClient = new SubstrateClientExt(new Uri(url), _chargeTypeDefault);

            ExtrinsicManager = new ExtrinsicManager(SubstrateClient);

            SubscriptionManager = new SubscriptionManager();
        }

        /// <summary>
        /// Connect to the network
        /// </summary>
        /// <param name="useMetadata"></param>
        /// <param name="standardSubstrate"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        public async Task<bool> ConnectAsync(bool useMetadata, bool standardSubstrate, CancellationToken token)
        {
            if (!IsConnected)
            {
                try
                {
                    await SubstrateClient.ConnectAsync(useMetadata, standardSubstrate, token);
                }
                catch (Exception e)
                {
                    Log.Error("BaseClient.ConnectAsync: {0}",
                        e.ToString());
                }
            }

            return IsConnected;
        }

        /// <summary>
        /// Disconnect from the network
        /// </summary>
        /// <returns></returns>
        public async Task<bool> DisconnectAsync()
        {
            if (!IsConnected)
            {
                return false;
            }

            await SubstrateClient.CloseAsync();
            return true;
        }

        /// <summary>
        /// Check if extrinsic can be sent
        /// </summary>
        /// <param name="extrinsicType"></param>
        /// <param name="concurrentTasks"></param>
        /// <returns></returns>
        public bool CanExtrinsic(string extrinsicType, int concurrentTasks)
            => IsConnected && !HasMaxConcurentTaskRunning() && !HasToManyConcurentTaskRunning(extrinsicType, concurrentTasks);

        /// <summary>
        /// Check if we have maximum of concurrent tasks running reached
        /// </summary>
        /// <returns></returns>
        public bool HasMaxConcurentTaskRunning()
            => ExtrinsicManager.Running.Count() >= _maxConcurrentCalls;

        /// <summary>
        /// Check if we have maximum of concurrent tasks running reached
        /// </summary>
        /// <param name="extrinsicType"></param>
        /// <param name="concurrentTasks"></param>
        /// <returns></returns>
        public bool HasToManyConcurentTaskRunning(string extrinsicType, int concurrentTasks)
            => ExtrinsicManager.Running.Count(p => p.ExtrinsicType == extrinsicType) >= concurrentTasks;

        /// <summary>
        /// Generic extrinsic sender
        /// </summary>
        /// <param name="extrinsicType"></param>
        /// <param name="extrinsicMethod"></param>
        /// <param name="concurrentTasks"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        internal async Task<string> GenericExtrinsicAsync(Account account, string extrinsicType, Method extrinsicMethod, int concurrentTasks, CancellationToken token)
        {
            if (account == null)
            {
                Log.Warning("Account is null!");
                return null;
            }

            if (!IsConnected)
            {
                Log.Warning("Currently not connected to the network!");
                return null;
            }

            if (HasMaxConcurentTaskRunning())
            {
                Log.Warning("There can not be more then {0} concurrent tasks overall!", _maxConcurrentCalls);
                return null;
            }

            if (HasToManyConcurentTaskRunning(extrinsicType, concurrentTasks))
            {
                Log.Warning("There can not be more then {0} concurrent tasks of {1}!", concurrentTasks, extrinsicType);
                return null;
            }

            string subscription = null;
            try
            {
                subscription = await SubstrateClient.Unstable.TransactionUnstableSubmitAndWatchAsync(ActionExtrinsicUpdate, extrinsicMethod, account, _chargeTypeDefault, 64, token);
            }
            catch (RemoteInvocationException e)
            {
                Log.Error("RemoteInvocationException: {0}", e.Message);
                return subscription;
            }

            if (subscription == null)
            {
                return null;
            }

            Log.Debug("Generic extrinsic sent {0} with {1}.", extrinsicMethod.ModuleName + "_" + extrinsicMethod.CallName, subscription);

            ExtrinsicManager.Add(subscription, extrinsicType);

            return subscription;
        }

        /// <summary>
        /// Callback for extrinsic update
        /// </summary>
        /// <param name="subscriptionId"></param>
        /// <param name="extrinsicUpdate"></param>
        public async void ActionExtrinsicUpdate(string subscriptionId, TransactionEventInfo extrinsicUpdate)
        {
            ExtrinsicManager.UpdateExtrinsicInfo(subscriptionId, extrinsicUpdate);

            var queueInfo = ExtrinsicManager.Get(subscriptionId);

            // proccessing events scrapping
            if (queueInfo != null && !queueInfo.HasEvents && extrinsicUpdate.Hash != null && extrinsicUpdate.Index != null)
            {
                string parameters = SystemStorage.EventsParams();
                var events = await SubstrateClient.GetStorageAsync<BaseVec<EventRecord>>(parameters, extrinsicUpdate.Hash.Value, CancellationToken.None);
                if (events == null)
                {
                    ExtrinsicManager.UpdateExtrinsicError(subscriptionId, "No block events");
                    return;
                }
                var allExtrinsicEvents = events.Value.Where(p => p.Phase.Value == Phase.ApplyExtrinsic && ((U32)p.Phase.Value2).Value == extrinsicUpdate.Index);
                if (!allExtrinsicEvents.Any())
                {
                    ExtrinsicManager.UpdateExtrinsicError(subscriptionId, "No extrinsic events");
                    return;
                }
                ExtrinsicManager.UpdateExtrinsicEvents(subscriptionId, allExtrinsicEvents);
            }
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="module"></param>
        /// <param name="startKey"></param>
        /// <param name="page"></param>
        /// <param name="blockHash"></param>
        /// <param name="token"></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        public async Task<List<(string, string)>?> GetAllStoragePagedAsync(string module, string? method, byte[]? startKey, uint page, string? blockHash, CancellationToken token)
        {
            if (!SubstrateClient.IsConnected)
            {
                return null;
            }

            if (page < 2 || page > 1000)
            {
                throw new NotSupportedException("Page size must be in the range of 2 - 1000");
            }

            var result = new List<(string, string)>();

            byte[]? keyBytes = method == null
                ? HashExtension.Twox128(Encoding.ASCII.GetBytes(module))
                : RequestGenerator.GetStorageKeyBytesHash(module, method);

            var storageKeys = await SubstrateClient.State.GetKeysPagedAsync(keyBytes, page, startKey, token);
            if (storageKeys == null || !storageKeys.Any())
            {
                return result;
            }

            var storageChangeSets = await SubstrateClient.State.GetQueryStorageAtAsync(storageKeys.Select(p => Utils.HexToByteArray(p.ToString())).ToList(), blockHash, token);
            if (storageChangeSets != null)
            {
                foreach (var storageChangeSet in storageChangeSets.First().Changes)
                {
                    result.Add((storageChangeSet[0], storageChangeSet[1]));
                }
            }

            return result;
        }
    }
}