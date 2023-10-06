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


namespace Substrate.Tanssi.NET.NetApiExt.Generated.Model.polkadot_primitives.v4
{
    
    
    /// <summary>
    /// >> 166 - Composite[polkadot_primitives.v4.PersistedValidationData]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class PersistedValidationData : BaseType
    {
        
        /// <summary>
        /// >> parent_head
        /// </summary>
        private Substrate.Tanssi.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData _parentHead;
        
        /// <summary>
        /// >> relay_parent_number
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _relayParentNumber;
        
        /// <summary>
        /// >> relay_parent_storage_root
        /// </summary>
        private Substrate.Tanssi.NET.NetApiExt.Generated.Model.primitive_types.H256 _relayParentStorageRoot;
        
        /// <summary>
        /// >> max_pov_size
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxPovSize;
        
        public Substrate.Tanssi.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData ParentHead
        {
            get
            {
                return this._parentHead;
            }
            set
            {
                this._parentHead = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 RelayParentNumber
        {
            get
            {
                return this._relayParentNumber;
            }
            set
            {
                this._relayParentNumber = value;
            }
        }
        
        public Substrate.Tanssi.NET.NetApiExt.Generated.Model.primitive_types.H256 RelayParentStorageRoot
        {
            get
            {
                return this._relayParentStorageRoot;
            }
            set
            {
                this._relayParentStorageRoot = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxPovSize
        {
            get
            {
                return this._maxPovSize;
            }
            set
            {
                this._maxPovSize = value;
            }
        }
        
        public override string TypeName()
        {
            return "PersistedValidationData";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ParentHead.Encode());
            result.AddRange(RelayParentNumber.Encode());
            result.AddRange(RelayParentStorageRoot.Encode());
            result.AddRange(MaxPovSize.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ParentHead = new Substrate.Tanssi.NET.NetApiExt.Generated.Model.polkadot_parachain.primitives.HeadData();
            ParentHead.Decode(byteArray, ref p);
            RelayParentNumber = new Substrate.NetApi.Model.Types.Primitive.U32();
            RelayParentNumber.Decode(byteArray, ref p);
            RelayParentStorageRoot = new Substrate.Tanssi.NET.NetApiExt.Generated.Model.primitive_types.H256();
            RelayParentStorageRoot.Decode(byteArray, ref p);
            MaxPovSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxPovSize.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
