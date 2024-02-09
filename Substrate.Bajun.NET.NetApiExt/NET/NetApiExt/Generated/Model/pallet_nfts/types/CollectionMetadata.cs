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


namespace Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 477 - Composite[pallet_nfts.types.CollectionMetadata]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CollectionMetadata : BaseType
    {
        
        /// <summary>
        /// >> deposit
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 Deposit { get; set; }
        /// <summary>
        /// >> data
        /// </summary>
        public Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10 Data { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "CollectionMetadata";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Deposit.Encode());
            result.AddRange(Data.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Deposit = new Substrate.NetApi.Model.Types.Primitive.U128();
            Deposit.Decode(byteArray, ref p);
            Data = new Substrate.Bajun.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT10();
            Data.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
