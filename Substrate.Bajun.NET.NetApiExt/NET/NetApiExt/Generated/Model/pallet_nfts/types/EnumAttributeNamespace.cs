//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Types.Base;
using System.Collections.Generic;


namespace Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> AttributeNamespace
    /// </summary>
    public enum AttributeNamespace
    {
        
        /// <summary>
        /// >> Pallet
        /// </summary>
        Pallet = 0,
        
        /// <summary>
        /// >> CollectionOwner
        /// </summary>
        CollectionOwner = 1,
        
        /// <summary>
        /// >> ItemOwner
        /// </summary>
        ItemOwner = 2,
        
        /// <summary>
        /// >> Account
        /// </summary>
        Account = 3,
    }
    
    /// <summary>
    /// >> 147 - Variant[pallet_nfts.types.AttributeNamespace]
    /// </summary>
    public sealed class EnumAttributeNamespace : BaseEnumExt<AttributeNamespace, BaseVoid, BaseVoid, BaseVoid, Substrate.Bajun.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>
    {
    }
}
