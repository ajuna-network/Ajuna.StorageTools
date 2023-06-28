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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.pallet_nfts.types
{
    
    
    /// <summary>
    /// >> 343 - Composite[pallet_nfts.types.ItemDeposit]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class ItemDeposit : BaseType
    {
        
        /// <summary>
        /// >> account
        /// </summary>
        private Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 _account;
        
        /// <summary>
        /// >> amount
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U128 _amount;
        
        public Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32 Account
        {
            get
            {
                return this._account;
            }
            set
            {
                this._account = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U128 Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }
        
        public override string TypeName()
        {
            return "ItemDeposit";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Account.Encode());
            result.AddRange(Amount.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Account = new Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.sp_core.crypto.AccountId32();
            Account.Decode(byteArray, ref p);
            Amount = new Substrate.NetApi.Model.Types.Primitive.U128();
            Amount.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
