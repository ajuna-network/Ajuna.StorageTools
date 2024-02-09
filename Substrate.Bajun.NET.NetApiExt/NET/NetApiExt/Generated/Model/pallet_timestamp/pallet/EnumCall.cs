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


namespace Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_timestamp.pallet
{
    
    
    /// <summary>
    /// >> Call
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public enum Call
    {
        
        /// <summary>
        /// >> set
        /// Set the current time.
        /// 
        /// This call should be invoked exactly once per block. It will panic at the finalization
        /// phase, if this call hasn't been invoked by that time.
        /// 
        /// The timestamp should be greater than the previous one by the amount specified by
        /// `MinimumPeriod`.
        /// 
        /// The dispatch origin for this call must be `Inherent`.
        /// 
        /// ## Complexity
        /// - `O(1)` (Note that implementations of `OnTimestampSet` must also be `O(1)`)
        /// - 1 storage read and 1 storage mutation (codec `O(1)`). (because of `DidUpdate::take` in
        ///   `on_finalize`)
        /// - 1 event handler `on_timestamp_set`. Must be `O(1)`.
        /// </summary>
        set = 0,
    }
    
    /// <summary>
    /// >> 201 - Variant[pallet_timestamp.pallet.Call]
    /// Contains one variant per dispatchable that can be called by an extrinsic.
    /// </summary>
    public sealed class EnumCall : BaseEnumExt<Call, Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U64>>
    {
    }
}
