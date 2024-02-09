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


namespace Substrate.Bajun.NET.NetApiExt.Generated.Model.polkadot_primitives.v4
{
    
    
    /// <summary>
    /// >> 183 - Composite[polkadot_primitives.v4.AbridgedHostConfiguration]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class AbridgedHostConfiguration : BaseType
    {
        
        /// <summary>
        /// >> max_code_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxCodeSize { get; set; }
        /// <summary>
        /// >> max_head_data_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxHeadDataSize { get; set; }
        /// <summary>
        /// >> max_upward_queue_count
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardQueueCount { get; set; }
        /// <summary>
        /// >> max_upward_queue_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardQueueSize { get; set; }
        /// <summary>
        /// >> max_upward_message_size
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardMessageSize { get; set; }
        /// <summary>
        /// >> max_upward_message_num_per_candidate
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxUpwardMessageNumPerCandidate { get; set; }
        /// <summary>
        /// >> hrmp_max_message_num_per_candidate
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 HrmpMaxMessageNumPerCandidate { get; set; }
        /// <summary>
        /// >> validation_upgrade_cooldown
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ValidationUpgradeCooldown { get; set; }
        /// <summary>
        /// >> validation_upgrade_delay
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 ValidationUpgradeDelay { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "AbridgedHostConfiguration";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(MaxCodeSize.Encode());
            result.AddRange(MaxHeadDataSize.Encode());
            result.AddRange(MaxUpwardQueueCount.Encode());
            result.AddRange(MaxUpwardQueueSize.Encode());
            result.AddRange(MaxUpwardMessageSize.Encode());
            result.AddRange(MaxUpwardMessageNumPerCandidate.Encode());
            result.AddRange(HrmpMaxMessageNumPerCandidate.Encode());
            result.AddRange(ValidationUpgradeCooldown.Encode());
            result.AddRange(ValidationUpgradeDelay.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            MaxCodeSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxCodeSize.Decode(byteArray, ref p);
            MaxHeadDataSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxHeadDataSize.Decode(byteArray, ref p);
            MaxUpwardQueueCount = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardQueueCount.Decode(byteArray, ref p);
            MaxUpwardQueueSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardQueueSize.Decode(byteArray, ref p);
            MaxUpwardMessageSize = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardMessageSize.Decode(byteArray, ref p);
            MaxUpwardMessageNumPerCandidate = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxUpwardMessageNumPerCandidate.Decode(byteArray, ref p);
            HrmpMaxMessageNumPerCandidate = new Substrate.NetApi.Model.Types.Primitive.U32();
            HrmpMaxMessageNumPerCandidate.Decode(byteArray, ref p);
            ValidationUpgradeCooldown = new Substrate.NetApi.Model.Types.Primitive.U32();
            ValidationUpgradeCooldown.Decode(byteArray, ref p);
            ValidationUpgradeDelay = new Substrate.NetApi.Model.Types.Primitive.U32();
            ValidationUpgradeDelay.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
