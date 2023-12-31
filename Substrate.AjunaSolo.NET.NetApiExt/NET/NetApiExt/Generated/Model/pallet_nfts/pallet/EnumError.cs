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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_nfts.pallet
{
    
    
    public enum Error
    {
        
        NoPermission = 0,
        
        UnknownCollection = 1,
        
        AlreadyExists = 2,
        
        ApprovalExpired = 3,
        
        WrongOwner = 4,
        
        BadWitness = 5,
        
        CollectionIdInUse = 6,
        
        ItemsNonTransferable = 7,
        
        NotDelegate = 8,
        
        WrongDelegate = 9,
        
        Unapproved = 10,
        
        Unaccepted = 11,
        
        ItemLocked = 12,
        
        LockedItemAttributes = 13,
        
        LockedCollectionAttributes = 14,
        
        LockedItemMetadata = 15,
        
        LockedCollectionMetadata = 16,
        
        MaxSupplyReached = 17,
        
        MaxSupplyLocked = 18,
        
        MaxSupplyTooSmall = 19,
        
        UnknownItem = 20,
        
        UnknownSwap = 21,
        
        NotForSale = 22,
        
        BidTooLow = 23,
        
        ReachedApprovalLimit = 24,
        
        DeadlineExpired = 25,
        
        WrongDuration = 26,
        
        MethodDisabled = 27,
        
        WrongSetting = 28,
        
        InconsistentItemConfig = 29,
        
        NoConfig = 30,
        
        RolesNotCleared = 31,
        
        MintNotStarted = 32,
        
        MintEnded = 33,
        
        AlreadyClaimed = 34,
        
        IncorrectData = 35,
    }
    
    /// <summary>
    /// >> 359 - Variant[pallet_nfts.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
