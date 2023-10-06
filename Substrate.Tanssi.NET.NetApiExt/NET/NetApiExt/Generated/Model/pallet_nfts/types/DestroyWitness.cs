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


namespace Substrate.Tanssi.NET.NetApiExt.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 228 - Composite[pallet_nfts.types.DestroyWitness]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class DestroyWitness : BaseType
    {
        
        /// <summary>
        /// >> item_metadatas
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _itemMetadatas;
        
        /// <summary>
        /// >> item_configs
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _itemConfigs;
        
        /// <summary>
        /// >> attributes
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> _attributes;
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> ItemMetadatas
        {
            get
            {
                return this._itemMetadatas;
            }
            set
            {
                this._itemMetadatas = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> ItemConfigs
        {
            get
            {
                return this._itemConfigs;
            }
            set
            {
                this._itemConfigs = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32> Attributes
        {
            get
            {
                return this._attributes;
            }
            set
            {
                this._attributes = value;
            }
        }
        
        public override string TypeName()
        {
            return "DestroyWitness";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(ItemMetadatas.Encode());
            result.AddRange(ItemConfigs.Encode());
            result.AddRange(Attributes.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            ItemMetadatas = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            ItemMetadatas.Decode(byteArray, ref p);
            ItemConfigs = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            ItemConfigs.Decode(byteArray, ref p);
            Attributes = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U32>();
            Attributes.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
