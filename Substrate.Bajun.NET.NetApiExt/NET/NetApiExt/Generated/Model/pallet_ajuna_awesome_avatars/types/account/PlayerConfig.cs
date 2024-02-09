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


namespace Substrate.Bajun.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.account
{
    
    
    /// <summary>
    /// >> 451 - Composite[pallet_ajuna_awesome_avatars.types.account.PlayerConfig]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PlayerConfig : BaseType
    {
        
        /// <summary>
        /// >> free_mints
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U16 FreeMints { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "PlayerConfig";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(FreeMints.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            FreeMints = new Substrate.NetApi.Model.Types.Primitive.U16();
            FreeMints.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
