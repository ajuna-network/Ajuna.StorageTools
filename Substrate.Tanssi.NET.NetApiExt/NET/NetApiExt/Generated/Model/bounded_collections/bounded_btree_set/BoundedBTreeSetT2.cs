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


namespace Substrate.Tanssi.NET.NetApiExt.Generated.Model.bounded_collections.bounded_btree_set
{
    
    
    /// <summary>
    /// >> 337 - Composite[bounded_collections.bounded_btree_set.BoundedBTreeSetT2]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedBTreeSetT2 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.Tanssi.NET.NetApiExt.Generated.Types.Base.BTreeSetT3 _value;
        
        public Substrate.Tanssi.NET.NetApiExt.Generated.Types.Base.BTreeSetT3 Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        public override string TypeName()
        {
            return "BoundedBTreeSetT2";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Value.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Value = new Substrate.Tanssi.NET.NetApiExt.Generated.Types.Base.BTreeSetT3();
            Value.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
