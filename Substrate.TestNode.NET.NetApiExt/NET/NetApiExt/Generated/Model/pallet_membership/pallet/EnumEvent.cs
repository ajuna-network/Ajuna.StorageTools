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


namespace Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_membership.pallet
{
    
    
    /// <summary>
    /// >> Event
    /// The `Event` enum of this pallet
    /// </summary>
    public enum Event
    {
        
        /// <summary>
        /// >> MemberAdded
        /// The given member was added; see the transaction for who.
        /// </summary>
        MemberAdded = 0,
        
        /// <summary>
        /// >> MemberRemoved
        /// The given member was removed; see the transaction for who.
        /// </summary>
        MemberRemoved = 1,
        
        /// <summary>
        /// >> MembersSwapped
        /// Two members were swapped; see the transaction for who.
        /// </summary>
        MembersSwapped = 2,
        
        /// <summary>
        /// >> MembersReset
        /// The membership was reset; see the transaction for who the new set is.
        /// </summary>
        MembersReset = 3,
        
        /// <summary>
        /// >> KeyChanged
        /// One of the members' keys changed.
        /// </summary>
        KeyChanged = 4,
        
        /// <summary>
        /// >> Dummy
        /// Phantom member, never used.
        /// </summary>
        Dummy = 5,
    }
    
    /// <summary>
    /// >> 117 - Variant[pallet_membership.pallet.Event]
    /// The `Event` enum of this pallet
    /// </summary>
    public sealed class EnumEvent : BaseEnum<Event>
    {
    }
}
