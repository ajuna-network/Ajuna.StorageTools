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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_ajuna_nft_transfer.pallet
{
    
    
    public enum Error
    {
        
        EmptyIpfsUrl = 0,
        
        DuplicateItemCode = 1,
        
        UnknownItem = 2,
        
        UnknownClaim = 3,
        
        NftNotOwned = 4,
        
        NftOutsideOfChain = 5,
        
        ItemRestoreFailure = 6,
    }
    
    /// <summary>
    /// >> 361 - Variant[pallet_ajuna_nft_transfer.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
