using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class User
{
    public short UserId { get; set; }

    public string? UserName { get; set; }

    public string? UserLogin { get; set; }

    public string? UserPassword { get; set; }

    public int? EmployeeId { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public bool? IsMobileUser { get; set; }

    public string? PlayerId { get; set; }

    public bool? LeadPopup { get; set; }

    public bool? CallRecording { get; set; }

    public string? PasswordTwo { get; set; }

    public string? DeviceId { get; set; }

    public string? AcceptingStatus { get; set; }

    public string? Bpcode { get; set; }

    public string? FinanceDeviceId { get; set; }

    public DateTime? Logindatetime { get; set; }

    public string? TeamMasterSerialNos { get; set; }

    public string? TeamLeaderSerialNos { get; set; }

    public virtual ICollection<AssetHandingOver> AssetHandingOvers { get; set; } = new List<AssetHandingOver>();

    public virtual ICollection<AssetPartialPayment> AssetPartialPayments { get; set; } = new List<AssetPartialPayment>();

    public virtual ICollection<AssetTransfer> AssetTransfers { get; set; } = new List<AssetTransfer>();

    public virtual ICollection<BookingFormReceiving> BookingFormReceivings { get; set; } = new List<BookingFormReceiving>();

    public virtual ICollection<CampaignsAnalysis> CampaignsAnalyses { get; set; } = new List<CampaignsAnalysis>();

    public virtual ICollection<CommissionPayment> CommissionPayments { get; set; } = new List<CommissionPayment>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Crcancellation> Crcancellations { get; set; } = new List<Crcancellation>();

    public virtual ICollection<CustomerReceiptPrint> CustomerReceiptPrints { get; set; } = new List<CustomerReceiptPrint>();

    public virtual ICollection<DealerQuotum> DealerQuota { get; set; } = new List<DealerQuotum>();

    public virtual ICollection<FacebookLead> FacebookLeads { get; set; } = new List<FacebookLead>();

    public virtual ICollection<FormsIssuance> FormsIssuances { get; set; } = new List<FormsIssuance>();

    public virtual ICollection<FormsReceiving> FormsReceivings { get; set; } = new List<FormsReceiving>();

    public virtual ICollection<FormsReturn> FormsReturns { get; set; } = new List<FormsReturn>();

    public virtual ICollection<Glreceipt> Glreceipts { get; set; } = new List<Glreceipt>();

    public virtual ICollection<InBoundInventory> InBoundInventories { get; set; } = new List<InBoundInventory>();

    public virtual ICollection<InstallmentReceiptDelivery> InstallmentReceiptDeliveries { get; set; } = new List<InstallmentReceiptDelivery>();

    public virtual ICollection<InstallmentReceipt> InstallmentReceipts { get; set; } = new List<InstallmentReceipt>();

    public virtual ICollection<InvestorDetail> InvestorDetails { get; set; } = new List<InvestorDetail>();

    public virtual ICollection<InvestorRegistration> InvestorRegistrations { get; set; } = new List<InvestorRegistration>();

    public virtual ICollection<ItemBoqplan> ItemBoqplans { get; set; } = new List<ItemBoqplan>();

    public virtual ICollection<PendingLead> PendingLeads { get; set; } = new List<PendingLead>();

    public virtual ICollection<ProjectExchange> ProjectExchanges { get; set; } = new List<ProjectExchange>();

    public virtual ICollection<ProjectSale> ProjectSaleMusers { get; set; } = new List<ProjectSale>();

    public virtual ICollection<ProjectSale> ProjectSaleSusers { get; set; } = new List<ProjectSale>();

    public virtual ICollection<ProjectTransfer> ProjectTransferMusers { get; set; } = new List<ProjectTransfer>();

    public virtual ICollection<ProjectTransfer> ProjectTransferSusers { get; set; } = new List<ProjectTransfer>();

    public virtual ICollection<QuotaAllocation> QuotaAllocations { get; set; } = new List<QuotaAllocation>();

    public virtual ICollection<RegionRight> RegionRights { get; set; } = new List<RegionRight>();

    public virtual ICollection<TeamLeader> TeamLeaders { get; set; } = new List<TeamLeader>();

    public virtual ICollection<TradingReceiptsPayment> TradingReceiptsPayments { get; set; } = new List<TradingReceiptsPayment>();

    public virtual ICollection<TradingTokenReceipt> TradingTokenReceipts { get; set; } = new List<TradingTokenReceipt>();

    public virtual ICollection<TradingTokenReturn> TradingTokenReturns { get; set; } = new List<TradingTokenReturn>();

    public virtual ICollection<Trading> Tradings { get; set; } = new List<Trading>();

    public virtual ICollection<UserAndPartyMaping> UserAndPartyMapingMusers { get; set; } = new List<UserAndPartyMaping>();

    public virtual ICollection<UserAndPartyMaping> UserAndPartyMapingSusers { get; set; } = new List<UserAndPartyMaping>();

    public virtual ICollection<UserAndPartyMaping> UserAndPartyMapingUsers { get; set; } = new List<UserAndPartyMaping>();

    public virtual ICollection<UsersActiveTime> UsersActiveTimes { get; set; } = new List<UsersActiveTime>();

    public virtual ICollection<Visitor> Visitors { get; set; } = new List<Visitor>();

    public virtual ICollection<WarehouseReceiptNew> WarehouseReceiptNewMusers { get; set; } = new List<WarehouseReceiptNew>();

    public virtual ICollection<WarehouseReceiptNew> WarehouseReceiptNewSusers { get; set; } = new List<WarehouseReceiptNew>();

    public virtual ICollection<WarehouseTransferNew> WarehouseTransferNewMusers { get; set; } = new List<WarehouseTransferNew>();

    public virtual ICollection<WarehouseTransferNew> WarehouseTransferNewSusers { get; set; } = new List<WarehouseTransferNew>();
}
