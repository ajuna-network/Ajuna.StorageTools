//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi;
using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types;
using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;


namespace Substrate.Tanssi.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class RandomnessStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public RandomnessStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Randomness", "RandomMaterial"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.Tanssi.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19)));
        }
        
        /// <summary>
        /// >> RandomMaterialParams
        ///  Series of block headers from the last 81 blocks that acts as random seed material. This
        ///  is arranged as a ring buffer with `block_number % 81` being the index into the `Vec` of
        ///  the oldest hash.
        /// </summary>
        public static string RandomMaterialParams()
        {
            return RequestGenerator.GetStorage("Randomness", "RandomMaterial", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> RandomMaterialDefault
        /// Default value as hex string
        /// </summary>
        public static string RandomMaterialDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> RandomMaterial
        ///  Series of block headers from the last 81 blocks that acts as random seed material. This
        ///  is arranged as a ring buffer with `block_number % 81` being the index into the `Vec` of
        ///  the oldest hash.
        /// </summary>
        public async Task<Substrate.Tanssi.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19> RandomMaterial(CancellationToken token)
        {
            string parameters = RandomnessStorage.RandomMaterialParams();
            var result = await _client.GetStorageAsync<Substrate.Tanssi.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT19>(parameters, token);
            return result;
        }
    }
    
    public sealed class RandomnessCalls
    {
    }
    
    public sealed class RandomnessConstants
    {
    }
}