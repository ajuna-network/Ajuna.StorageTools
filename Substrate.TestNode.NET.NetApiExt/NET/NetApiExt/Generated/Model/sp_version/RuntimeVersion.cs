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


namespace Substrate.TestNode.NET.NetApiExt.Generated.Model.sp_version
{
    
    
    /// <summary>
    /// >> 168 - Composite[sp_version.RuntimeVersion]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class RuntimeVersion : BaseType
    {
        
        /// <summary>
        /// >> spec_name
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Str SpecName { get; set; }
        /// <summary>
        /// >> impl_name
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.Str ImplName { get; set; }
        /// <summary>
        /// >> authoring_version
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 AuthoringVersion { get; set; }
        /// <summary>
        /// >> spec_version
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 SpecVersion { get; set; }
        /// <summary>
        /// >> impl_version
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ImplVersion { get; set; }
        /// <summary>
        /// >> apis
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Types.Base.Cow Apis { get; set; }
        /// <summary>
        /// >> transaction_version
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 TransactionVersion { get; set; }
        /// <summary>
        /// >> state_version
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 StateVersion { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "RuntimeVersion";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SpecName.Encode());
            result.AddRange(ImplName.Encode());
            result.AddRange(AuthoringVersion.Encode());
            result.AddRange(SpecVersion.Encode());
            result.AddRange(ImplVersion.Encode());
            result.AddRange(Apis.Encode());
            result.AddRange(TransactionVersion.Encode());
            result.AddRange(StateVersion.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SpecName = new Substrate.NetApi.Model.Types.Primitive.Str();
            SpecName.Decode(byteArray, ref p);
            ImplName = new Substrate.NetApi.Model.Types.Primitive.Str();
            ImplName.Decode(byteArray, ref p);
            AuthoringVersion = new Substrate.NetApi.Model.Types.Primitive.U32();
            AuthoringVersion.Decode(byteArray, ref p);
            SpecVersion = new Substrate.NetApi.Model.Types.Primitive.U32();
            SpecVersion.Decode(byteArray, ref p);
            ImplVersion = new Substrate.NetApi.Model.Types.Primitive.U32();
            ImplVersion.Decode(byteArray, ref p);
            Apis = new Substrate.TestNode.NET.NetApiExt.Generated.Types.Base.Cow();
            Apis.Decode(byteArray, ref p);
            TransactionVersion = new Substrate.NetApi.Model.Types.Primitive.U32();
            TransactionVersion.Decode(byteArray, ref p);
            StateVersion = new Substrate.NetApi.Model.Types.Primitive.U8();
            StateVersion.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
