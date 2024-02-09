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
    /// >> Error
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public enum Error
    {
        
        /// <summary>
        /// >> NotMember
        /// Account is not a member
        /// </summary>
        NotMember = 0,
        
        /// <summary>
        /// >> DuplicateProposal
        /// Duplicate proposals not allowed
        /// </summary>
        DuplicateProposal = 1,
        
        /// <summary>
        /// >> ProposalMissing
        /// Proposal must exist
        /// </summary>
        ProposalMissing = 2,
        
        /// <summary>
        /// >> WrongIndex
        /// Mismatched index
        /// </summary>
        WrongIndex = 3,
        
        /// <summary>
        /// >> DuplicateVote
        /// Duplicate vote ignored
        /// </summary>
        DuplicateVote = 4,
        
        /// <summary>
        /// >> AlreadyInitialized
        /// Members are already initialized!
        /// </summary>
        AlreadyInitialized = 5,
        
        /// <summary>
        /// >> TooEarly
        /// The close call was made too early, before the end of the voting.
        /// </summary>
        TooEarly = 6,
        
        /// <summary>
        /// >> TooManyProposals
        /// There can only be a maximum of `MaxProposals` active proposals.
        /// </summary>
        TooManyProposals = 7,
        
        /// <summary>
        /// >> WrongProposalWeight
        /// The given weight bound for the proposal was too low.
        /// </summary>
        WrongProposalWeight = 8,
        
        /// <summary>
        /// >> WrongProposalLength
        /// The given length bound for the proposal was too low.
        /// </summary>
        WrongProposalLength = 9,
    }
    
    /// <summary>
    /// >> 441 - Variant[pallet_collective.pallet.Error]
    /// 
    ///			Custom [dispatch errors](https://docs.substrate.io/main-docs/build/events-errors/)
    ///			of this pallet.
    ///			
    /// </summary>
    public sealed class EnumError : BaseEnum<Error>
    {
    }
}
