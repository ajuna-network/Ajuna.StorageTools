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


namespace Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.fee
{
    
    
    /// <summary>
    /// >> 128 - Composite[pallet_ajuna_awesome_avatars.types.fee.Fee]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Fee : BaseType
    {
        
        /// <summary>
        /// >> mint
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.fee.MintFees Mint { get; set; }
        /// <summary>
        /// >> transfer_avatar
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 TransferAvatar { get; set; }
        /// <summary>
        /// >> buy_minimum
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 BuyMinimum { get; set; }
        /// <summary>
        /// >> buy_percent
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 BuyPercent { get; set; }
        /// <summary>
        /// >> upgrade_storage
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 UpgradeStorage { get; set; }
        /// <summary>
        /// >> prepare_avatar
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U128 PrepareAvatar { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Fee";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Mint.Encode());
            result.AddRange(TransferAvatar.Encode());
            result.AddRange(BuyMinimum.Encode());
            result.AddRange(BuyPercent.Encode());
            result.AddRange(UpgradeStorage.Encode());
            result.AddRange(PrepareAvatar.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Mint = new Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.fee.MintFees();
            Mint.Decode(byteArray, ref p);
            TransferAvatar = new Substrate.NetApi.Model.Types.Primitive.U128();
            TransferAvatar.Decode(byteArray, ref p);
            BuyMinimum = new Substrate.NetApi.Model.Types.Primitive.U128();
            BuyMinimum.Decode(byteArray, ref p);
            BuyPercent = new Substrate.NetApi.Model.Types.Primitive.U8();
            BuyPercent.Decode(byteArray, ref p);
            UpgradeStorage = new Substrate.NetApi.Model.Types.Primitive.U128();
            UpgradeStorage.Decode(byteArray, ref p);
            PrepareAvatar = new Substrate.NetApi.Model.Types.Primitive.U128();
            PrepareAvatar.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
