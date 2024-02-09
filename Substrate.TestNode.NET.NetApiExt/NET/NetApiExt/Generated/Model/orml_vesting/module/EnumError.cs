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


namespace Substrate.TestNode.NET.NetApiExt.Generated.Model.orml_vesting.module
{
    
    
    /// <summary>
    /// >> Error
    /// The `Error` enum of this pallet.
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> ZeroVestingPeriod
        /// Vesting period is zero
        /// </summary>
        ZeroVestingPeriod = 0,
        
        /// <summary>
        /// >> ZeroVestingPeriodCount
        /// Number of vests is zero
        /// </summary>
        ZeroVestingPeriodCount = 1,
        
        /// <summary>
        /// >> InsufficientBalanceToLock
        /// Insufficient amount of balance to lock
        /// </summary>
        InsufficientBalanceToLock = 2,
        
        /// <summary>
        /// >> TooManyVestingSchedules
        /// This account have too many vesting schedules
        /// </summary>
        TooManyVestingSchedules = 3,
        
        /// <summary>
        /// >> AmountLow
        /// The vested transfer amount is too low
        /// </summary>
        AmountLow = 4,
        
        /// <summary>
        /// >> MaxVestingSchedulesExceeded
        /// Failed because the maximum vesting schedules was exceeded
        /// </summary>
        MaxVestingSchedulesExceeded = 5,
    }
    
    /// <summary>
    /// >> 393 - Variant[orml_vesting.module.Error]
    /// The `Error` enum of this pallet.
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
