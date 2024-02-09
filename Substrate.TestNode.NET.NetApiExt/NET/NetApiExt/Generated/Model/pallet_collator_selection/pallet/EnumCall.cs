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


namespace Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_collator_selection.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set_invulnerables
        /// See [`Pallet::set_invulnerables`].
        /// </summary>
        set_invulnerables = 0,
        
        /// <summary>
        /// >> set_desired_candidates
        /// See [`Pallet::set_desired_candidates`].
        /// </summary>
        set_desired_candidates = 1,
        
        /// <summary>
        /// >> set_candidacy_bond
        /// See [`Pallet::set_candidacy_bond`].
        /// </summary>
        set_candidacy_bond = 2,
        
        /// <summary>
        /// >> register_as_candidate
        /// See [`Pallet::register_as_candidate`].
        /// </summary>
        register_as_candidate = 3,
        
        /// <summary>
        /// >> leave_intent
        /// See [`Pallet::leave_intent`].
        /// </summary>
        leave_intent = 4,
        
        /// <summary>
        /// >> add_invulnerable
        /// See [`Pallet::add_invulnerable`].
        /// </summary>
        add_invulnerable = 5,
        
        /// <summary>
        /// >> remove_invulnerable
        /// See [`Pallet::remove_invulnerable`].
        /// </summary>
        remove_invulnerable = 6,
    }
    
    /// <summary>
    /// >> 278 - Variant[pallet_collator_selection.pallet.Call]
    /// Contains a variant per dispatchable extrinsic that this pallet has.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.TestNode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>, Substrate.NetApi.Model.Types.Primitive.U32, Substrate.NetApi.Model.Types.Primitive.U128, BaseVoid, BaseVoid, Substrate.TestNode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32, Substrate.TestNode.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32>
    {
    }
}
