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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_assets.types
{
    
    
    public enum ExistenceReason
    {
        
        Consumer = 0,
        
        Sufficient = 1,
        
        DepositHeld = 2,
        
        DepositRefunded = 3,
    }
    
    /// <summary>
    /// >> 157 - Variant[pallet_assets.types.ExistenceReason]
    /// </summary>
    public sealed class EnumExistenceReason : BaseEnumExt<ExistenceReason, BaseVoid, BaseVoid, Substrate.NetApi.Model.Types.Primitive.U128, BaseVoid>
    {
    }
}
