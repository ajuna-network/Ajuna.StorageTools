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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_core.bounded.bounded_btree_set
{
    
    
    /// <summary>
    /// >> 328 - Composite[sp_core.bounded.bounded_btree_set.BoundedBTreeSetT1]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class BoundedBTreeSetT1 : BaseType
    {
        
        /// <summary>
        /// >> value
        /// </summary>
        private Substrate.AjunaSolo.NET.NetApiExt.Generated.Types.Base.BTreeSetT1 _value;
        
        public Substrate.AjunaSolo.NET.NetApiExt.Generated.Types.Base.BTreeSetT1 Value
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
            return "BoundedBTreeSetT1";
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
            Value = new Substrate.AjunaSolo.NET.NetApiExt.Generated.Types.Base.BTreeSetT1();
            Value.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
