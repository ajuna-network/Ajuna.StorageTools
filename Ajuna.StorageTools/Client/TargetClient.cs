using System.Text;
using Ajuna.StorageTools.Helper;
using Schnorrkel.Keys;
using Serilog;
using StreamJsonRpc;
using Substrate.AjunaSolo.NET.NetApiExt.Generated;
using Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.ajuna_solo_runtime;
using Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_core.crypto;
using Substrate.AjunaSolo.NET.NetApiExt.Generated.Storage;
using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;

namespace Ajuna.StorageTools.Client
{
    public class TargetClient
    {
        private readonly int _maxConcurrentCalls;

        private readonly ChargeType _chargeTypeDefault;

        public static MiniSecret MiniSecretAlice => new MiniSecret(Utils.HexToByteArray("0xe5be9a5092b81bca64be81d212e7f2f9eba183bb7a90954f7b76361f6edb5c0a"), ExpandMode.Ed25519);
        public static Account Alice => Account.Build(KeyType.Sr25519, MiniSecretAlice.ExpandToSecret().ToBytes(), MiniSecretAlice.GetPair().Public.Key);

        public ExtrinsicManager ExtrinsicManger { get; }

        public SubscriptionManager SubscriptionManager { get; }

        public SubstrateClientExt SubstrateClient { get; }

        public bool IsConnected => SubstrateClient.IsConnected;

        public TargetClient(string url, int maxConcurrentCalls = 10)
        {
            //_chargeTypeDefault = ChargeTransactionPayment.Default();
            _chargeTypeDefault = ChargeAssetTxPayment.Default();

            _maxConcurrentCalls = maxConcurrentCalls;

            SubstrateClient = new SubstrateClientExt(new Uri(url), _chargeTypeDefault);

            ExtrinsicManger = new ExtrinsicManager();

            SubscriptionManager = new SubscriptionManager();
        }

        /// <summary>
        ///
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
        ///
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

            if (ExtrinsicManger.Running.Count() >= _maxConcurrentCalls)
            {
                Log.Warning("There can not be more then {0} concurrent tasks overall!", _maxConcurrentCalls);
                return null;
            }

            if (ExtrinsicManger.Running.Count(p => p.ExtrinsicType == extrinsicType) >= concurrentTasks)
            {
                Log.Warning("There can not be more then {0} concurrent tasks of {1}!", concurrentTasks, extrinsicType);
                return null;
            }

            string subscription = null;
            try
            {
                subscription = await SubstrateClient.Author.SubmitAndWatchExtrinsicAsync(ExtrinsicManger.ActionExtrinsicUpdate, extrinsicMethod, account, _chargeTypeDefault, 64, token);
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

            ExtrinsicManger.Add(subscription, extrinsicType);
            return subscription;
        }

        public async Task<string> SubscribeEventsAsync(CancellationToken token)
        {
            if (!IsConnected)
            {
                Log.Warning("Currently not connected to the network!");
                return null;
            }

            if (SubscriptionManager.IsSubscribed)
            {
                Log.Warning("Already active subscription to events!");
                return null;
            }

            var subscription = await SubstrateClient.SubscribeStorageKeyAsync(SystemStorage.EventsParams(), SubscriptionManager.ActionSubscrptionEvent, token);
            if (subscription == null)
            {
                return null;
            }

            SubscriptionManager.IsSubscribed = true;

            Log.Debug("SystemStorage.Events subscription id {0] registred.", subscription);

            return subscription;
        }

        public static Account RandomAccount(int seed, string derivationPsw = "aA1234dd", KeyType keyType = KeyType.Sr25519)
        {
            var random = new Random(seed);
            var randomBytes = new byte[16];
            random.NextBytes(randomBytes);
            var mnemonic = string.Join(" ", Mnemonic.MnemonicFromEntropy(randomBytes, Mnemonic.BIP39Wordlist.English));
            Log.Information("mnemonic[Sr25519]: {0}", mnemonic);
            return Mnemonic.GetAccountFromMnemonic(mnemonic, derivationPsw, keyType);
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
        public async Task<List<(string, string)>?> GetAllStoragePagedAsync(string module, byte[] startKey, uint page, string blockHash, CancellationToken token)
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
            
            var keyBytes = HashExtension.Twox128(Encoding.ASCII.GetBytes(module));

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

        public static EnumRuntimeCall? GetCallSetStorage(List<(string,string)> keyValuePairs)
        {
            var baseTupleArray = keyValuePairs.Select((p) => new BaseTuple<BaseVec<U8>, BaseVec<U8>>(new BaseVec<U8>(p.Item1.ToU8Array()), new BaseVec<U8>(p.Item2.ToU8Array()))).ToArray();
            var setStorage = new BaseVec<BaseTuple<BaseVec<U8>, BaseVec<U8>>>(baseTupleArray);

            var call = new Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumCall();
            call.Create(Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.frame_system.pallet.Call.set_storage, setStorage);

            var enumCall = new EnumRuntimeCall();
            enumCall.Create(RuntimeCall.System, call);

            return enumCall;
        }

    }
}