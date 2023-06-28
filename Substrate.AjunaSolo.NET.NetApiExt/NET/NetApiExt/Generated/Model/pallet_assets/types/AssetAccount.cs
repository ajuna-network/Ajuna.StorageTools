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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_assets.types
{
    
    
    /// <summary>
    /// >> 156 - Composite[pallet_assets.types.AssetAccount]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AssetAccount : BaseType
    {
        
        /// <summary>
        /// >> balance
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _balance;
        
        /// <summary>
        /// >> is_frozen
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _isFrozen;
        
        /// <summary>
        /// >> reason
        /// </summary>
        private Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_assets.types.EnumExistenceReason _reason;
        
        /// <summary>
        /// >> extra
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseTuple _extra;
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Balance
        {
            get
            {
                return this._balance;
            }
            set
            {
                this._balance = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool IsFrozen
        {
            get
            {
                return this._isFrozen;
            }
            set
            {
                this._isFrozen = value;
            }
        }
        
        public Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_assets.types.EnumExistenceReason Reason
        {
            get
            {
                return this._reason;
            }
            set
            {
                this._reason = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseTuple Extra
        {
            get
            {
                return this._extra;
            }
            set
            {
                this._extra = value;
            }
        }
        
        public override string TypeName()
        {
            return "AssetAccount";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Balance.Encode());
            result.AddRange(IsFrozen.Encode());
            result.AddRange(Reason.Encode());
            result.AddRange(Extra.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Balance = new Substrate.NetApi.Model.Types.Primitive.U128();
            Balance.Decode(byteArray, ref p);
            IsFrozen = new Substrate.NetApi.Model.Types.Primitive.Bool();
            IsFrozen.Decode(byteArray, ref p);
            Reason = new Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_assets.types.EnumExistenceReason();
            Reason.Decode(byteArray, ref p);
            Extra = new Substrate.NetApi.Model.Types.Base.BaseTuple();
            Extra.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
