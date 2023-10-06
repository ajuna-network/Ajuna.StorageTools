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


namespace Substrate.Tanssi.NET.NetApiExt.Generated.Model.polkadot_core_primitives
{
    
    
    /// <summary>
    /// >> 188 - Composite[polkadot_core_primitives.InboundDownwardMessage]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class InboundDownwardMessage : BaseType
    {
        
        /// <summary>
        /// >> sent_at
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _sentAt;
        
        /// <summary>
        /// >> msg
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> _msg;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 SentAt
        {
            get
            {
                return this._sentAt;
            }
            set
            {
                this._sentAt = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8> Msg
        {
            get
            {
                return this._msg;
            }
            set
            {
                this._msg = value;
            }
        }
        
        public override string TypeName()
        {
            return "InboundDownwardMessage";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SentAt.Encode());
            result.AddRange(Msg.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SentAt = new Substrate.NetApi.Model.Types.Primitive.U32();
            SentAt.Decode(byteArray, ref p);
            Msg = new Substrate.NetApi.Model.Types.Base.BaseVec<Substrate.NetApi.Model.Types.Primitive.U8>();
            Msg.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
