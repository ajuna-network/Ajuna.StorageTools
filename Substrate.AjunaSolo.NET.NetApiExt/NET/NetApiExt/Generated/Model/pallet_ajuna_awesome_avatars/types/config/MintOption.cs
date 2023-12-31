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
    /// >> 235 - Composite[pallet_ajuna_awesome_avatars.types.config.MintOption]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class MintOption : BaseType
    {
        
        /// <summary>
        /// >> mint_type
        /// </summary>
        private Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintType _mintType;
        
        /// <summary>
        /// >> count
        /// </summary>
        private Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPackSize _count;
        
        public Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintType MintType
        {
            get
            {
                return this._mintType;
            }
            set
            {
                this._mintType = value;
            }
        }
        
        public Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPackSize Count
        {
            get
            {
                return this._count;
            }
            set
            {
                this._count = value;
            }
        }
        
        public override string TypeName()
        {
            return "MintOption";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MintType.Encode());
            result.AddRange(Count.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MintType = new Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintType();
            MintType.Decode(byteArray, ref p);
            Count = new Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.config.EnumMintPackSize();
            Count.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
