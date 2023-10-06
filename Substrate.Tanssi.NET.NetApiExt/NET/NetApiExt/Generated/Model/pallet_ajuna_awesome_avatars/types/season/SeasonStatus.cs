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


namespace Substrate.Tanssi.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season
{
    
    
    /// <summary>
    /// >> 296 - Composite[pallet_ajuna_awesome_avatars.types.season.SeasonStatus]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class SeasonStatus : BaseType
    {
        
        /// <summary>
        /// >> season_id
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U16 _seasonId;
        
        /// <summary>
        /// >> early
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _early;
        
        /// <summary>
        /// >> active
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _active;
        
        /// <summary>
        /// >> early_ended
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.Bool _earlyEnded;
        
        /// <summary>
        /// >> max_tier_avatars
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _maxTierAvatars;
        
        public Substrate.NetApi.Model.Types.Primitive.U16 SeasonId
        {
            get
            {
                return this._seasonId;
            }
            set
            {
                this._seasonId = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool Early
        {
            get
            {
                return this._early;
            }
            set
            {
                this._early = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool Active
        {
            get
            {
                return this._active;
            }
            set
            {
                this._active = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.Bool EarlyEnded
        {
            get
            {
                return this._earlyEnded;
            }
            set
            {
                this._earlyEnded = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxTierAvatars
        {
            get
            {
                return this._maxTierAvatars;
            }
            set
            {
                this._maxTierAvatars = value;
            }
        }
        
        public override string TypeName()
        {
            return "SeasonStatus";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(SeasonId.Encode());
            result.AddRange(Early.Encode());
            result.AddRange(Active.Encode());
            result.AddRange(EarlyEnded.Encode());
            result.AddRange(MaxTierAvatars.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            SeasonId = new Substrate.NetApi.Model.Types.Primitive.U16();
            SeasonId.Decode(byteArray, ref p);
            Early = new Substrate.NetApi.Model.Types.Primitive.Bool();
            Early.Decode(byteArray, ref p);
            Active = new Substrate.NetApi.Model.Types.Primitive.Bool();
            Active.Decode(byteArray, ref p);
            EarlyEnded = new Substrate.NetApi.Model.Types.Primitive.Bool();
            EarlyEnded.Decode(byteArray, ref p);
            MaxTierAvatars = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxTierAvatars.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
