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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_runtime
{
    
    
    public enum TokenError
    {
        
        NoFunds = 0,
        
        WouldDie = 1,
        
        BelowMinimum = 2,
        
        CannotCreate = 3,
        
        UnknownAsset = 4,
        
        Frozen = 5,
        
        Unsupported = 6,
    }
    
    /// <summary>
    /// >> 26 - Variant[sp_runtime.TokenError]
    /// </summary>
    public sealed class EnumTokenError : BaseEnum<TokenError>
    {
    }
}
