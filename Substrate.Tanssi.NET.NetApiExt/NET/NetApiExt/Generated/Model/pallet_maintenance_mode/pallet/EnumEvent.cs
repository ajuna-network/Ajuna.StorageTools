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


namespace Substrate.Tanssi.NET.NetApiExt.Generated.Model.pallet_maintenance_mode.pallet
{
    
    
    public enum Event
    {
        
        EnteredMaintenanceMode = 0,
        
        NormalOperationResumed = 1,
        
        FailedToSuspendIdleXcmExecution = 2,
        
        FailedToResumeIdleXcmExecution = 3,
    }
    
    /// <summary>
    /// >> 41 - Variant[pallet_maintenance_mode.pallet.Event]
    /// 
    ///			The [event](https://docs.substrate.io/main-docs/build/events-errors/) emitted
    ///			by this pallet.
    ///			
    /// </summary>
    public sealed class EnumEvent : BaseEnumExt<Event, BaseVoid, BaseVoid, Substrate.Tanssi.NET.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError, Substrate.Tanssi.NET.NetApiExt.Generated.Model.sp_runtime.EnumDispatchError>
    {
    }
}
