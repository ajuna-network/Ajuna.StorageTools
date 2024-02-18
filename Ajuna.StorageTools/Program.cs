using Ajuna.StorageTools.Client;
using Ajuna.StorageTools.Helper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Yaml;
using Serilog;
using Substrate.Integration.Helper;
using Substrate.NetApi;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Primitive;
using Substrate.Bajun.NET.NetApiExt.Generated.Model.bajun_runtime;
using Substrate.Bajun.NET.NetApiExt.Generated.Storage;

namespace Ajuna.StorageTools
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            // configure serilog
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Information()
                .WriteTo
                .Console()
                .CreateLogger();

            var config = new ConfigurationBuilder()
                // this will be used more later on
                .SetBasePath(AppContext.BaseDirectory)
                // I chose using YML files for my config data as I am familiar with them
                .AddYamlFile("config.yml")
                .Build();

            // Add this to your C# console app's Main method to give yourself
            // a CancellationToken that is canceled when the user hits Ctrl+C.
            var cts = new CancellationTokenSource();
            Console.CancelKeyPress += (s, e) =>
            {
                Console.WriteLine("Canceling...");
                cts.Cancel();
                e.Cancel = true;
            };

            try
            {
                Console.WriteLine("Press Ctrl+C to end.");
                await MainAsync(config, cts.Token);
            }
            catch (OperationCanceledException)
            {
                // This is the normal way we close.
            }

            // Finally, once just before the application exits...
            await Log.CloseAndFlushAsync();
        }

        private static async Task MainAsync(IConfigurationRoot config, CancellationToken token)
        {
            var modules = new List<string[]> {
//                new string [] {"AwesomeAvatars" },
//                new string [] {"System", "Account" },
                new string [] { "Identity" },
                new string [] { "XcmpQueue" },
            };

            string sourceUrl = config["node:source"];

            var client = new BaseClient(sourceUrl, NetworkType.Live, 100);
            await client.ConnectAsync(true, true, token);
            var block = await client.SubstrateClient.Chain.GetBlockAsync();
            var blockHash = block.Block.Header.ParentHash.Value;
            Log.Information("Block: {0}, Parent Hash: {1}", block.Block.Header.Number.Value, blockHash);

            await client.DisconnectAsync();

            foreach (var moduleMethod in modules)
            {
                Log.Information("Module: {0}", string.Join("-", moduleMethod));
                List<(string, string)> allPagesSource = await GetStorageOfSourceAsync(sourceUrl, moduleMethod, blockHash, token);

                Log.Information("Waiting to execute set storage on target!");
                Thread.Sleep(10000);

                await CloneStorageToTargetAsync(config["node:target"], allPagesSource, token);

                Log.Information("Waiting to control with get storage on target!");
                Thread.Sleep(10000);
                _ = await GetStorageOfTargetAsync(config["node:target"], moduleMethod, null, token);
            }
        }

        private static async Task<List<(string, string)>> GetStorageOfSourceAsync(string url, string[] moduleMethod, string? blockHash, CancellationToken token)
        {
            var client = new BaseClient(url, NetworkType.Live, 100);
            await client.ConnectAsync(true, true, token);
            Log.Information("{0}: Connected to {1}: {2}", "Source", url, client.IsConnected);

            byte[]? startKeySource = null;

            List<(string, string)> allPages = new();

            while (true)
            {
                var page = await client.GetAllStoragePagedAsync(moduleMethod[0], moduleMethod.Length == 2 ? moduleMethod[1] : null, startKeySource, 1000, blockHash, token);
                if (page == null || page.Count == 0)
                {
                    break;
                }

                allPages.AddRange(page);
                startKeySource = Utils.HexToByteArray(page[page.Count - 1].Item1);
            }

            Log.Information("{0}: Parsed {1} entries!", "Source", allPages.Count);

            await client.DisconnectAsync();

            return allPages;
        }

        private static async Task<List<(string, string)>> GetStorageOfTargetAsync(string url, string[] moduleMethod, string? blockHash, CancellationToken token)
        {
            var client = new BaseClient(url, NetworkType.Live, 100);
            await client.ConnectAsync(true, true, token);
            Log.Information("{0}: Connected to {1}: {2}", "Target", url, client.IsConnected);

            byte[]? startKeySource = null;

            List<(string, string)> allPages = new();

            while (true)
            {
                var page = await client.GetAllStoragePagedAsync(moduleMethod[0], moduleMethod.Length == 2 ? moduleMethod[1] : null, startKeySource, 1000, blockHash, token);
                if (page == null || page.Count == 0)
                {
                    break;
                }

                allPages.AddRange(page);
                startKeySource = Utils.HexToByteArray(page[page.Count - 1].Item1);
            }

            Log.Information("{0}: Parsed {1} entries!", "Target", allPages.Count);

            await client.DisconnectAsync();

            return allPages;
        }

        private static async Task CloneStorageToTargetAsync(string url, List<(string, string)> allPagesSource, CancellationToken token)
        {
            var batches = Generic.BuildChunksWithLinqAndYield(allPagesSource, 1000);

            var targetClient = new BaseClient(url, NetworkType.Live, 100);
            await targetClient.ConnectAsync(true, true, token);
            Log.Information("{0}: Connected to {1}: {2}", "Target", url, targetClient.IsConnected);

            targetClient.ExtrinsicManager.ExtrinsicUpdated += (s, e) =>
            {
                Log.Debug("{0}: ExtrinsicUpdated: {1}", "Target", e.TransactionEvent);
            };

            for (int i = 0; i < batches.Count(); i++)
            {
                Log.Information("{0}: Processing batch {1} of {2}", "Target", i, batches.Count());
                var batch = batches.ElementAt(i);

                var baseTupleList = new List<BaseTuple<BaseVec<U8>, BaseVec<U8>>>();
                foreach (var record in batch)
                {
                    var keyBaseVec = new BaseVec<U8>();
                    keyBaseVec.Create(Utils.HexToByteArray(record.Item1).ToU8Array());

                    var valueBaseVec = new BaseVec<U8>();
                    valueBaseVec.Create(Utils.HexToByteArray(record.Item2).ToU8Array());

                    var baseTuple = new BaseTuple<BaseVec<U8>, BaseVec<U8>>();
                    baseTuple.Create(keyBaseVec, valueBaseVec);

                    baseTupleList.Add(baseTuple);
                }

                var setStorage = new BaseVec<BaseTuple<BaseVec<U8>, BaseVec<U8>>>();
                setStorage.Create(baseTupleList.ToArray());

                var call = new Substrate.Bajun.NET.NetApiExt.Generated.Model.frame_system.pallet.EnumCall();
                call.Create(Substrate.Bajun.NET.NetApiExt.Generated.Model.frame_system.pallet.Call.set_storage, setStorage);

                var enumCall = new EnumRuntimeCall();
                enumCall.Create(RuntimeCall.System, call);

                var extrinsic = SudoCalls.Sudo(enumCall);

                var subscriptionId = await targetClient.GenericExtrinsicAsync(BaseClient.Alice, "SetStorage", extrinsic, 100, token);
                if (subscriptionId == null)
                {
                    Log.Warning("{0}: subscriptionId is null.", "Target");
                    break;
                }

                //while (targetClient.ExtrinsicManager.PreInblock.Count() > 25)
                while (targetClient.ExtrinsicManager.PreInblock.Any())
                {
                    Log.Information("{0}: waiting on extrinsic to be in block.", "Target");
                    await Task.Delay(10000);
                }
            }

            await targetClient.DisconnectAsync();
        }
    }
}