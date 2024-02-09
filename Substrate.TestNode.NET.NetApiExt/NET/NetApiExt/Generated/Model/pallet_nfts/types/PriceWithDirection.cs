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


namespace Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 149 - Composite[pallet_nfts.types.PriceWithDirection]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PriceWithDirection : BaseType
    {
        
        /// <summary>
        /// >> amount
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount { get; set; }
        /// <summary>
        /// >> direction
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_nfts.types.EnumPriceDirection Direction { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PriceWithDirection";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Amount.Encode());
            result.AddRange(Direction.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            Direction = new Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_nfts.types.EnumPriceDirection();
            Direction.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
