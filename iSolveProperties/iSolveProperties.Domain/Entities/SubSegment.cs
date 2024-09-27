using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SubSegment
{
    public short SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte? SegmentId { get; set; }

    public byte CompId { get; set; }

    public string? CaSubSegment { get; set; }

    public byte[]? SubSegmentPic { get; set; }

    public bool? CrprintWaterMark { get; set; }

    public bool? AllowBackDate { get; set; }

    public string? ContactPerson { get; set; }

    public DateOnly? BackDateTill { get; set; }

    public string? Prefix { get; set; }

    public byte? Prints { get; set; }

    public short? AllowLateDays { get; set; }

    public bool? Glrestriction { get; set; }

    public bool? GlvoucherApprovedWaterMark { get; set; }

    public bool? ClientOfficeCopyOnGlprint { get; set; }

    public string? WebLink { get; set; }

    public virtual ICollection<AssetAdditionModification> AssetAdditionModifications { get; set; } = new List<AssetAdditionModification>();

    public virtual ICollection<AssetDisposal> AssetDisposals { get; set; } = new List<AssetDisposal>();

    public virtual ICollection<AssetHandingOver> AssetHandingOvers { get; set; } = new List<AssetHandingOver>();

    public virtual ICollection<AssetPartialPayment> AssetPartialPayments { get; set; } = new List<AssetPartialPayment>();

    public virtual ICollection<AssetTransfer> AssetTransferSubSegmentNavigations { get; set; } = new List<AssetTransfer>();

    public virtual ICollection<AssetTransfer> AssetTransferSubSegments { get; set; } = new List<AssetTransfer>();

    public virtual ICollection<BookingConfirmationLetter> BookingConfirmationLetters { get; set; } = new List<BookingConfirmationLetter>();

    public virtual ICollection<BookingFormReceiving> BookingFormReceivings { get; set; } = new List<BookingFormReceiving>();

    public virtual ICollection<BudgetDefinition> BudgetDefinitions { get; set; } = new List<BudgetDefinition>();

    public virtual ICollection<CommissionPayment> CommissionPayments { get; set; } = new List<CommissionPayment>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<Crcancellation> Crcancellations { get; set; } = new List<Crcancellation>();

    public virtual ICollection<CustomerReceiptPrint> CustomerReceiptPrints { get; set; } = new List<CustomerReceiptPrint>();

    public virtual ICollection<DealPurchaseModified> DealPurchaseModifieds { get; set; } = new List<DealPurchaseModified>();

    public virtual ICollection<DealerQuotum> DealerQuota { get; set; } = new List<DealerQuotum>();

    public virtual ICollection<DeliveryDispatchMaster> DeliveryDispatchMasters { get; set; } = new List<DeliveryDispatchMaster>();

    public virtual ICollection<Depreciation> Depreciations { get; set; } = new List<Depreciation>();

    public virtual ICollection<EmailCompaign> EmailCompaigns { get; set; } = new List<EmailCompaign>();

    public virtual ICollection<Glreceipt> Glreceipts { get; set; } = new List<Glreceipt>();

    public virtual ICollection<IgpMaster> IgpMasters { get; set; } = new List<IgpMaster>();

    public virtual ICollection<Igpmaster1> Igpmaster1s { get; set; } = new List<Igpmaster1>();

    public virtual ICollection<InBoundInventory> InBoundInventories { get; set; } = new List<InBoundInventory>();

    public virtual ICollection<InstallmentPlan> InstallmentPlans { get; set; } = new List<InstallmentPlan>();

    public virtual ICollection<InstallmentReceiptDelivery> InstallmentReceiptDeliveries { get; set; } = new List<InstallmentReceiptDelivery>();

    public virtual ICollection<InstallmentReceipt> InstallmentReceipts { get; set; } = new List<InstallmentReceipt>();

    public virtual ICollection<InvestmentReturn> InvestmentReturns { get; set; } = new List<InvestmentReturn>();

    public virtual ICollection<InvestorDetail> InvestorDetails { get; set; } = new List<InvestorDetail>();

    public virtual ICollection<InvestorRegistration> InvestorRegistrations { get; set; } = new List<InvestorRegistration>();

    public virtual ICollection<IpMain> IpMains { get; set; } = new List<IpMain>();

    public virtual ICollection<ItemBoqplan> ItemBoqplans { get; set; } = new List<ItemBoqplan>();

    public virtual ICollection<PartialReceipt> PartialReceipts { get; set; } = new List<PartialReceipt>();

    public virtual ICollection<Pomaster> Pomasters { get; set; } = new List<Pomaster>();

    public virtual ICollection<ProjectExchange> ProjectExchanges { get; set; } = new List<ProjectExchange>();

    public virtual ICollection<ProjectReversal> ProjectReversals { get; set; } = new List<ProjectReversal>();

    public virtual ICollection<ProjectSale> ProjectSales { get; set; } = new List<ProjectSale>();

    public virtual ICollection<ProjectTransfer> ProjectTransfers { get; set; } = new List<ProjectTransfer>();

    public virtual ICollection<ProjectWiseGl> ProjectWiseGls { get; set; } = new List<ProjectWiseGl>();

    public virtual ICollection<QuotaAllocationModified> QuotaAllocationModifieds { get; set; } = new List<QuotaAllocationModified>();

    public virtual ICollection<QuotaAllocation> QuotaAllocations { get; set; } = new List<QuotaAllocation>();

    public virtual ICollection<RegionRight> RegionRights { get; set; } = new List<RegionRight>();

    public virtual ICollection<RequisitionMaster> RequisitionMasters { get; set; } = new List<RequisitionMaster>();

    public virtual ICollection<StockIssue> StockIssues { get; set; } = new List<StockIssue>();

    public virtual ICollection<SubletService> SubletServices { get; set; } = new List<SubletService>();

    public virtual ICollection<Sublet> Sublets { get; set; } = new List<Sublet>();

    public virtual ICollection<TradingClosing> TradingClosings { get; set; } = new List<TradingClosing>();

    public virtual ICollection<TradingReceiptsPayment> TradingReceiptsPayments { get; set; } = new List<TradingReceiptsPayment>();

    public virtual ICollection<TradingTokenReceipt> TradingTokenReceipts { get; set; } = new List<TradingTokenReceipt>();

    public virtual ICollection<TradingTokenReturn> TradingTokenReturns { get; set; } = new List<TradingTokenReturn>();

    public virtual ICollection<Visitor> Visitors { get; set; } = new List<Visitor>();

    public virtual ICollection<WarehouseReceiptNew> WarehouseReceiptNews { get; set; } = new List<WarehouseReceiptNew>();

    public virtual ICollection<WarehouseTransferNew> WarehouseTransferNews { get; set; } = new List<WarehouseTransferNew>();
}
