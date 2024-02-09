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


namespace Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.season
{
    
    
    /// <summary>
    /// >> 119 - Composite[pallet_ajuna_awesome_avatars.types.season.Season]
    /// </summary>
    [SubstrateNodeType(TypeDefEnum.Composite)]
    public sealed class Season : BaseType
    {
        
        /// <summary>
        /// >> name
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4 Name { get; set; }
        /// <summary>
        /// >> description
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5 Description { get; set; }
        /// <summary>
        /// >> early_start
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 EarlyStart { get; set; }
        /// <summary>
        /// >> start
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 Start { get; set; }
        /// <summary>
        /// >> end
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 End { get; set; }
        /// <summary>
        /// >> max_tier_forges
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 MaxTierForges { get; set; }
        /// <summary>
        /// >> max_variations
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 MaxVariations { get; set; }
        /// <summary>
        /// >> max_components
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 MaxComponents { get; set; }
        /// <summary>
        /// >> min_sacrifices
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 MinSacrifices { get; set; }
        /// <summary>
        /// >> max_sacrifices
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 MaxSacrifices { get; set; }
        /// <summary>
        /// >> tiers
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6 Tiers { get; set; }
        /// <summary>
        /// >> single_mint_probs
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 SingleMintProbs { get; set; }
        /// <summary>
        /// >> batch_mint_probs
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7 BatchMintProbs { get; set; }
        /// <summary>
        /// >> base_prob
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U8 BaseProb { get; set; }
        /// <summary>
        /// >> per_period
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U32 PerPeriod { get; set; }
        /// <summary>
        /// >> periods
        /// </summary>
        public Substrate.NetApi.Model.Types.Primitive.U16 Periods { get; set; }
        /// <summary>
        /// >> trade_filters
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8 TradeFilters { get; set; }
        /// <summary>
        /// >> fee
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.fee.Fee Fee { get; set; }
        /// <summary>
        /// >> mint_logic
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration MintLogic { get; set; }
        /// <summary>
        /// >> forge_logic
        /// </summary>
        public Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration ForgeLogic { get; set; }
        
        /// <inheritdoc/>
        public override string TypeName()
        {
            return "Season";
        }
        
        /// <inheritdoc/>
        public override byte[] Encode()
        {
            var result = new List<byte>();
            result.AddRange(Name.Encode());
            result.AddRange(Description.Encode());
            result.AddRange(EarlyStart.Encode());
            result.AddRange(Start.Encode());
            result.AddRange(End.Encode());
            result.AddRange(MaxTierForges.Encode());
            result.AddRange(MaxVariations.Encode());
            result.AddRange(MaxComponents.Encode());
            result.AddRange(MinSacrifices.Encode());
            result.AddRange(MaxSacrifices.Encode());
            result.AddRange(Tiers.Encode());
            result.AddRange(SingleMintProbs.Encode());
            result.AddRange(BatchMintProbs.Encode());
            result.AddRange(BaseProb.Encode());
            result.AddRange(PerPeriod.Encode());
            result.AddRange(Periods.Encode());
            result.AddRange(TradeFilters.Encode());
            result.AddRange(Fee.Encode());
            result.AddRange(MintLogic.Encode());
            result.AddRange(ForgeLogic.Encode());
            return result.ToArray();
        }
        
        /// <inheritdoc/>
        public override void Decode(byte[] byteArray, ref int p)
        {
            var start = p;
            Name = new Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT4();
            Name.Decode(byteArray, ref p);
            Description = new Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT5();
            Description.Decode(byteArray, ref p);
            EarlyStart = new Substrate.NetApi.Model.Types.Primitive.U32();
            EarlyStart.Decode(byteArray, ref p);
            Start = new Substrate.NetApi.Model.Types.Primitive.U32();
            Start.Decode(byteArray, ref p);
            End = new Substrate.NetApi.Model.Types.Primitive.U32();
            End.Decode(byteArray, ref p);
            MaxTierForges = new Substrate.NetApi.Model.Types.Primitive.U32();
            MaxTierForges.Decode(byteArray, ref p);
            MaxVariations = new Substrate.NetApi.Model.Types.Primitive.U8();
            MaxVariations.Decode(byteArray, ref p);
            MaxComponents = new Substrate.NetApi.Model.Types.Primitive.U8();
            MaxComponents.Decode(byteArray, ref p);
            MinSacrifices = new Substrate.NetApi.Model.Types.Primitive.U8();
            MinSacrifices.Decode(byteArray, ref p);
            MaxSacrifices = new Substrate.NetApi.Model.Types.Primitive.U8();
            MaxSacrifices.Decode(byteArray, ref p);
            Tiers = new Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT6();
            Tiers.Decode(byteArray, ref p);
            SingleMintProbs = new Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7();
            SingleMintProbs.Decode(byteArray, ref p);
            BatchMintProbs = new Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT7();
            BatchMintProbs.Decode(byteArray, ref p);
            BaseProb = new Substrate.NetApi.Model.Types.Primitive.U8();
            BaseProb.Decode(byteArray, ref p);
            PerPeriod = new Substrate.NetApi.Model.Types.Primitive.U32();
            PerPeriod.Decode(byteArray, ref p);
            Periods = new Substrate.NetApi.Model.Types.Primitive.U16();
            Periods.Decode(byteArray, ref p);
            TradeFilters = new Substrate.TestNode.NET.NetApiExt.Generated.Model.bounded_collections.bounded_vec.BoundedVecT8();
            TradeFilters.Decode(byteArray, ref p);
            Fee = new Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.fee.Fee();
            Fee.Decode(byteArray, ref p);
            MintLogic = new Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration();
            MintLogic.Decode(byteArray, ref p);
            ForgeLogic = new Substrate.TestNode.NET.NetApiExt.Generated.Model.pallet_ajuna_awesome_avatars.types.avatar.EnumLogicGeneration();
            ForgeLogic.Decode(byteArray, ref p);
            var bytesLength = p - start;
            TypeSize = bytesLength;
            Bytes = new byte[bytesLength];
            System.Array.Copy(byteArray, start, Bytes, 0, bytesLength);
        }
    }
}
