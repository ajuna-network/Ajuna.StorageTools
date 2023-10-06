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


namespace Substrate.Tanssi.NET.NetApiExt.Generated.Model.cumulus_pallet_parachain_system
{
    
    
    /// <summary>
    /// >> 184 - Composite[cumulus_pallet_parachain_system.CodeUpgradeAuthorization]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class CodeUpgradeAuthorization : BaseType
    {
        
        /// <summary>
        /// >> code_hash
        /// </summary>
        private Substrate.Tanssi.NET.NetApiExt.Generated.Model.primitive_types.H256 _codeHash;
        
        /// <summary>
        /// >> check_version
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _checkVersion;
        
        public Substrate.Tanssi.NET.NetApiExt.Generated.Model.primitive_types.H256 CodeHash
        {
            get
            {
                return this._codeHash;
            }
            set
            {
                this._codeHash = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool CheckVersion
        {
            get
            {
                return this._checkVersion;
            }
            set
            {
                this._checkVersion = value;
            }
        }
        
        public override string TypeName()
        {
            return "CodeUpgradeAuthorization";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(CodeHash.Encode());
            result.AddRange(CheckVersion.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            CodeHash = new Substrate.Tanssi.NET.NetApiExt.Generated.Model.primitive_types.H256();
            CodeHash.Decode(byteArray, ref p);
            CheckVersion = new Substrate.NetApi.Model.Types.Primitive.Bool();
            CheckVersion.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
