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


namespace Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_nft_transfer.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> ItemStored
        /// Item has been stored as an NFT [collection_id, item_id, owner]
        /// </summary>
        ItemStored = 0,
        
        /// <summary>
        /// >> ItemRestored
        /// Item has been restored back from its NFT representation [collection_id, item_id, owner]
        /// </summary>
        ItemRestored = 1,
    }
    
    /// <summary>
    /// >> 152 - Variant[pallet_ajuna_nft_transfer.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.TestNode.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.TestNode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, BaseTuple<Substrate.NetApi.Model.Types.Primitive.U32, Substrate.TestNode.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.TestNode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>>
    {
    }
}
