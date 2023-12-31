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


namespace Substrate.AjunaSolo.NET.NetApiExt.Generated.Model.orml_vesting
{
    
    
    /// <summary>
    /// >> 42 - Composite[orml_vesting.VestingSchedule]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class VestingSchedule : BaseType
    {
        
        /// <summary>
        /// >> start
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _start;
        
        /// <summary>
        /// >> period
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _period;
        
        /// <summary>
        /// >> period_count
        /// </summary>
        private Substrate.NetApi.Model.Types.Primitive.U32 _periodCount;
        
        /// <summary>
        /// >> per_period
        /// </summary>
        private Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> _perPeriod;
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Start
        {
            get
            {
                return this._start;
            }
            set
            {
                this._start = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 Period
        {
            get
            {
                return this._period;
            }
            set
            {
                this._period = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Primitive.U32 PeriodCount
        {
            get
            {
                return this._periodCount;
            }
            set
            {
                this._periodCount = value;
            }
        }
        
        public Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128> PerPeriod
        {
            get
            {
                return this._perPeriod;
            }
            set
            {
                this._perPeriod = value;
            }
        }
        
        public override string TypeName()
        {
            return "VestingSchedule";
        }
        
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Start.Encode());
            result.AddRange(Period.Encode());
            result.AddRange(PeriodCount.Encode());
            result.AddRange(PerPeriod.Encode());
            return result.ToArray();
        }
        
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Start = new Substrate.NetApi.Model.Types.Primitive.U32();
            Start.Decode(byteArray, ref p);
            Period = new Substrate.NetApi.Model.Types.Primitive.U32();
            Period.Decode(byteArray, ref p);
            PeriodCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            PeriodCount.Decode(byteArray, ref p);
            PerPeriod = new Substrate.NetApi.Model.Types.Base.BaseCom<Substrate.NetApi.Model.Types.Primitive.U128>();
            PerPeriod.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
