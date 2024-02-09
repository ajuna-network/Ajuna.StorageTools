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


namespace Substrate.Bajun.NET.NetApiExt.Generated.Storage
{
    
    
    /// <summary>
    /// >> PreimageStorage
    /// </summary>
    public sealed class PreimageStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        /// <summary>
        /// >> PreimageStorage Constructor
        /// </summary>
        public PreimageStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Preimage", "StatusFor"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256), typeof(Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus)));
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Preimage", "PreimageFor"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                            Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, typeof(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32>), typeof(Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23)));
        }
        
        /// <summary>
        /// >> StatusForParams
        ///  The request status of a given hash.
        /// </summary>
        public static string StatusForParams(Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256 key)
        {
            return RequestGenerator.GetStorage("Preimage", "StatusFor", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> StatusForDefault
        /// Default value as hex string
        /// </summary>
        public static string StatusForDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> StatusFor
        ///  The request status of a given hash.
        /// </summary>
        public async Task<Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus> StatusFor(Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256 key, string blockhash, CancellationToken token)
        {
            string parameters = PreimageStorage.StatusForParams(key);
            var result = await _client.GetStorageAsync<Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_preimage.EnumRequestStatus>(parameters, blockhash, token);
            return result;
        }
        
        /// <summary>
        /// >> PreimageForParams
        /// </summary>
        public static string PreimageForParams(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32> key)
        {
            return RequestGenerator.GetStorage("Preimage", "PreimageFor", Substrate.NetApi.Model.Meta.Storage.Type.Map, new Substrate.NetApi.Model.Meta.Storage.Hasher[] {
                        Substrate.NetApi.Model.Meta.Storage.Hasher.Identity}, new Substrate.NetApi.Model.Types.IType[] {
                        key});
        }
        
        /// <summary>
        /// >> PreimageForDefault
        /// Default value as hex string
        /// </summary>
        public static string PreimageForDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> PreimageFor
        /// </summary>
        public async Task<Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23> PreimageFor(Substrate.NetApi.Model.Types.Base.BaseTuple<Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32> key, string blockhash, CancellationToken token)
        {
            string parameters = PreimageStorage.PreimageForParams(key);
            var result = await _client.GetStorageAsync<Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT23>(parameters, blockhash, token);
            return result;
        }
    }
    
    /// <summary>
    /// >> PreimageCalls
    /// </summary>
    public sealed class PreimageCalls
    {
        
        /// <summary>
        /// >> note_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method NotePreimage(Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> bytes)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(bytes.Encode());
            return new Method(9, "Preimage", 0, "note_preimage", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unnote_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UnnotePreimage(Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256 hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            return new Method(9, "Preimage", 1, "unnote_preimage", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> request_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method RequestPreimage(Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256 hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            return new Method(9, "Preimage", 2, "request_preimage", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> unrequest_preimage
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method UnrequestPreimage(Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256 hash)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(hash.Encode());
            return new Method(9, "Preimage", 3, "unrequest_preimage", byteArray.ToArray());
        }
    }
    
    /// <summary>
    /// >> PreimageConstants
    /// </summary>
    public sealed class PreimageConstants
    {
    }
    
    /// <summary>
    /// >> PreimageErrors
    /// </summary>
    public enum PreimageErrors
    {
        
        /// <summary>
        /// >> TooBig
        /// Preimage is too large to store on-chain.
        /// </summary>
        TooBig,
        
        /// <summary>
        /// >> AlreadyNoted
        /// Preimage has already been noted on-chain.
        /// </summary>
        AlreadyNoted,
        
        /// <summary>
        /// >> NotAuthorized
        /// The user is not authorized to perform this action.
        /// </summary>
        NotAuthorized,
        
        /// <summary>
        /// >> NotNoted
        /// The preimage cannot be removed since it has not yet been noted.
        /// </summary>
        NotNoted,
        
        /// <summary>
        /// >> Requested
        /// A preimage may not be removed when there are outstanding requests.
        /// </summary>
        Requested,
        
        /// <summary>
        /// >> NotRequested
        /// The preimage request cannot be removed since no outstanding requests exist.
        /// </summary>
        NotRequested,
    }
}
