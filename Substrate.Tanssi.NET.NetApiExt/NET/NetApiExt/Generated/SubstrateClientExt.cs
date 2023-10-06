//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Substrate.NetApi.Model.Extrinsics;
using Substrate.NetApi.Model.Meta;
using Substrate.NetApi.Model.Types.Base;
using Substrate.Tanssi.NET.NetApiExt.Generated.Storage;
using System.Collections.Generic;


namespace Substrate.Tanssi.NET.NetApiExt.Generated
{
    
    
    public sealed class SubstrateClientExt : Substrate.NetApi.SubstrateClient
    {
        
        /// <summary>
        /// StorageKeyDict for key definition informations.
        /// </summary>
        public System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>> StorageKeyDict;
        
        /// <summary>
        /// SystemStorage storage calls.
        /// </summary>
        public SystemStorage SystemStorage;
        
        /// <summary>
        /// ParachainSystemStorage storage calls.
        /// </summary>
        public ParachainSystemStorage ParachainSystemStorage;
        
        /// <summary>
        /// TimestampStorage storage calls.
        /// </summary>
        public TimestampStorage TimestampStorage;
        
        /// <summary>
        /// ParachainInfoStorage storage calls.
        /// </summary>
        public ParachainInfoStorage ParachainInfoStorage;
        
        /// <summary>
        /// SudoStorage storage calls.
        /// </summary>
        public SudoStorage SudoStorage;
        
        /// <summary>
        /// UtilityStorage storage calls.
        /// </summary>
        public UtilityStorage UtilityStorage;
        
        /// <summary>
        /// ProxyStorage storage calls.
        /// </summary>
        public ProxyStorage ProxyStorage;
        
        /// <summary>
        /// MigrationsStorage storage calls.
        /// </summary>
        public MigrationsStorage MigrationsStorage;
        
        /// <summary>
        /// MaintenanceModeStorage storage calls.
        /// </summary>
        public MaintenanceModeStorage MaintenanceModeStorage;
        
        /// <summary>
        /// BalancesStorage storage calls.
        /// </summary>
        public BalancesStorage BalancesStorage;
        
        /// <summary>
        /// TransactionPaymentStorage storage calls.
        /// </summary>
        public TransactionPaymentStorage TransactionPaymentStorage;
        
        /// <summary>
        /// AwesomeAvatarsStorage storage calls.
        /// </summary>
        public AwesomeAvatarsStorage AwesomeAvatarsStorage;
        
        /// <summary>
        /// RandomnessStorage storage calls.
        /// </summary>
        public RandomnessStorage RandomnessStorage;
        
        /// <summary>
        /// NftStorage storage calls.
        /// </summary>
        public NftStorage NftStorage;
        
        /// <summary>
        /// NftTransferStorage storage calls.
        /// </summary>
        public NftTransferStorage NftTransferStorage;
        
        /// <summary>
        /// AuthoritiesNotingStorage storage calls.
        /// </summary>
        public AuthoritiesNotingStorage AuthoritiesNotingStorage;
        
        /// <summary>
        /// AuthorInherentStorage storage calls.
        /// </summary>
        public AuthorInherentStorage AuthorInherentStorage;
        
        /// <summary>
        /// XcmpQueueStorage storage calls.
        /// </summary>
        public XcmpQueueStorage XcmpQueueStorage;
        
        /// <summary>
        /// CumulusXcmStorage storage calls.
        /// </summary>
        public CumulusXcmStorage CumulusXcmStorage;
        
        /// <summary>
        /// DmpQueueStorage storage calls.
        /// </summary>
        public DmpQueueStorage DmpQueueStorage;
        
        /// <summary>
        /// PolkadotXcmStorage storage calls.
        /// </summary>
        public PolkadotXcmStorage PolkadotXcmStorage;
        
        public SubstrateClientExt(System.Uri uri, Substrate.NetApi.Model.Extrinsics.ChargeType chargeType) : 
                base(uri, chargeType)
        {
            StorageKeyDict = new System.Collections.Generic.Dictionary<System.Tuple<string, string>, System.Tuple<Substrate.NetApi.Model.Meta.Storage.Hasher[], System.Type, System.Type>>();
            this.SystemStorage = new SystemStorage(this);
            this.ParachainSystemStorage = new ParachainSystemStorage(this);
            this.TimestampStorage = new TimestampStorage(this);
            this.ParachainInfoStorage = new ParachainInfoStorage(this);
            this.SudoStorage = new SudoStorage(this);
            this.UtilityStorage = new UtilityStorage(this);
            this.ProxyStorage = new ProxyStorage(this);
            this.MigrationsStorage = new MigrationsStorage(this);
            this.MaintenanceModeStorage = new MaintenanceModeStorage(this);
            this.BalancesStorage = new BalancesStorage(this);
            this.TransactionPaymentStorage = new TransactionPaymentStorage(this);
            this.AwesomeAvatarsStorage = new AwesomeAvatarsStorage(this);
            this.RandomnessStorage = new RandomnessStorage(this);
            this.NftStorage = new NftStorage(this);
            this.NftTransferStorage = new NftTransferStorage(this);
            this.AuthoritiesNotingStorage = new AuthoritiesNotingStorage(this);
            this.AuthorInherentStorage = new AuthorInherentStorage(this);
            this.XcmpQueueStorage = new XcmpQueueStorage(this);
            this.CumulusXcmStorage = new CumulusXcmStorage(this);
            this.DmpQueueStorage = new DmpQueueStorage(this);
            this.PolkadotXcmStorage = new PolkadotXcmStorage(this);
        }
    }
}