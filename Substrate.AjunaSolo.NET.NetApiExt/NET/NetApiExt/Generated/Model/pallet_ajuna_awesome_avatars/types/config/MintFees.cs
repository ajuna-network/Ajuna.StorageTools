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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config
{
    
    
    /// <summary>
    /// >> 76 - Composite[pallet_ajuna_awesome_avatars.types.config.MintFees]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MintFees : BaseType
    {
        
        /// <summary>
        /// >> one
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _one;
        
        /// <summary>
        /// >> three
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _three;
        
        /// <summary>
        /// >> six
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _six;
        
        public Substrate.NetApi.Model.Types.Primitive.U128 One
        {
            get
            {
                return this._one;
            }
            set
            {
                this._one = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Three
        {
            get
            {
                return this._three;
            }
            set
            {
                this._three = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Six
        {
            get
            {
                return this._six;
            }
            set
            {
                this._six = value;
            }
        }
        
        public override string TypeName()
        {
            return "MintFees";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(One.Encode());
            result.AddRange(Three.Encode());
            result.AddRange(Six.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            One = new Substrate.NetApi.Model.Types.Primitive.U128();
            One.Decode(byteArray, ref p);
            Three = new Substrate.NetApi.Model.Types.Primitive.U128();
            Three.Decode(byteArray, ref p);
            Six = new Substrate.NetApi.Model.Types.Primitive.U128();
            Six.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
