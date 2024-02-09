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


namespace Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_collective.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> Proposed
        /// A motion (given hash) has been proposed (by given account) with a threshold (given
        /// `MemberCount`).
        /// </summary>
        Proposed = 0,
        
        /// <summary>
        /// >> Voted
        /// A motion (given hash) has been voted on by given account, leaving
        /// a tally (yes votes and no votes given respectively as `MemberCount`).
        /// </summary>
        Voted = 1,
        
        /// <summary>
        /// >> Approved
        /// A motion was approved by the required threshold.
        /// </summary>
        Approved = 2,
        
        /// <summary>
        /// >> Disapproved
        /// A motion was not approved by the required threshold.
        /// </summary>
        Disapproved = 3,
        
        /// <summary>
        /// >> Executed
        /// A motion was executed; result will be `Ok` if it returned without error.
        /// </summary>
        Executed = 4,
        
        /// <summary>
        /// >> MemberExecuted
        /// A single member did some action; result will be `Ok` if it returned without error.
        /// </summary>
        MemberExecuted = 5,
        
        /// <summary>
        /// >> Closed
        /// A proposal was closed because its threshold was reached or after its duration was up.
        /// </summary>
        Closed = 6,
    }
    
    /// <summary>
    /// >> 116 - Variant[pallet_collective.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseTuple<Substrate.Bajun.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32>, BaseTuple<Substrate.Bajun.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.Bool, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>, Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, BaseTuple<Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.Bajun.NET.NetApiExt.Generated.Types.Base.EnumResult>, BaseTuple<Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.Bajun.NET.NetApiExt.Generated.Types.Base.EnumResult>, BaseTuple<Substrate.Bajun.NET.NetApiExt.Generated.Model.primitive_types.H256, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U32>>
    {
    }
}
