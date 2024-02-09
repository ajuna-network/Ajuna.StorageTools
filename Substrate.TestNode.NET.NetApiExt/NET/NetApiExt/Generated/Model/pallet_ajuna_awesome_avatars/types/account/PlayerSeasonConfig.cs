//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Attributes;
using Substrate.NetApi.Model.Types.Base;
using Substrate.NetApi.Model.Types.Metadata.V14;
using System.Collections.Generic;


namespace Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account
{
    
    
    /// <summary>
    /// >> 468 - Composite[pallet_ajuna_awesome_avatars.types.account.PlayerSeasonConfig]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PlayerSeasonConfig : BaseType
    {
        
        /// <summary>
        /// >> storage_tier
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.EnumStorageTier StorageTier { get; set; }
        /// <summary>
        /// >> stats
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.Stats Stats { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PlayerSeasonConfig";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(StorageTier.Encode());
            result.AddRange(Stats.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            StorageTier = new Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.EnumStorageTier();
            StorageTier.Decode(byteArray, ref p);
            Stats = new Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account.Stats();
            Stats.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
