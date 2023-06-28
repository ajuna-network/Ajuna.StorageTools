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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Storage
{
    
    
    public sealed class SudoStorage
    {
        
        // Substrate client for the storage calls.
        private SubstrateClientExt _client;
        
        public SudoStorage(SubstrateClientExt client)
        {
            this._client = client;
            _client.StorageKeyDict.Add(new System.Tuple<string, string>("Sudo", "Key"), new System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>(null, null, typeof(Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32)));
        }
        
        /// <summary>
        /// >> KeyParams
        ///  The `AccountId` of the sudo key.
        /// </summary>
        public static string KeyParams()
        {
            return RequestGenerator.GetStorage("Sudo", "Key", Substrate.NetApi.Model.Meta.Storage.Type.Plain);
        }
        
        /// <summary>
        /// >> KeyDefault
        /// Default value as hex string
        /// </summary>
        public static string KeyDefault()
        {
            return "0x00";
        }
        
        /// <summary>
        /// >> Key
        ///  The `AccountId` of the sudo key.
        /// </summary>
        public async Task<Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32> Key(CancellationToken token)
        {
            string parameters = SudoStorage.KeyParams();
            var result = await _client.GetStorageAsync<Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>(parameters, token);
            return result;
        }
    }
    
    public sealed class SudoCalls
    {
        
        /// <summary>
        /// >> sudo
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method Sudo(Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.ajuna_solo_runtime.EnumRuntimeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            return new Method(13, "Sudo", 0, "sudo", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sudo_unchecked_weight
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SudoUncheckedWeight(Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.ajuna_solo_runtime.EnumRuntimeCall call, Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_weights.weight_v2.Weight weight)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(call.Encode());
            byteArray.AddRange(weight.Encode());
            return new Method(13, "Sudo", 1, "sudo_unchecked_weight", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> set_key
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SetKey(Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress @new)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(@new.Encode());
            return new Method(13, "Sudo", 2, "set_key", byteArray.ToArray());
        }
        
        /// <summary>
        /// >> sudo_as
        /// Contains one variant per dispatchable that can be called by an extrinsic.
        /// </summary>
        public static Method SudoAs(Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_runtime.multiaddress.EnumMultiAddress who, Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.ajuna_solo_runtime.EnumRuntimeCall call)
        {
            System.Collections.Generic.List<byte> byteArray = new List<byte>();
            byteArray.AddRange(who.Encode());
            byteArray.AddRange(call.Encode());
            return new Method(13, "Sudo", 3, "sudo_as", byteArray.ToArray());
        }
    }
    
    public sealed class SudoConstants
    {
    }
    
    public enum SudoErrors
    {
        
        /// <summary>
        /// >> RequireSudo
        /// Sender must be the Sudo account
        /// </summary>
        RequireSudo,
    }
}
