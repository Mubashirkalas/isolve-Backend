using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectRegistration
{
    public short SerialNo { get; set; }

    public byte CompId { get; set; }

    public string? Project { get; set; }

    public bool? InventoryPurchase { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public bool? AttachGlintegration { get; set; }

    public string? ProjectAddress { get; set; }

    public virtual ICollection<CampaignAllocation> CampaignAllocations { get; set; } = new List<CampaignAllocation>();

    public virtual ICollection<CampaignsAnalysis> CampaignsAnalyses { get; set; } = new List<CampaignsAnalysis>();

    public virtual ICollection<CustomerReceiptPrint> CustomerReceiptPrints { get; set; } = new List<CustomerReceiptPrint>();

    public virtual ICollection<DealPurchaseModified> DealPurchaseModifieds { get; set; } = new List<DealPurchaseModified>();

    public virtual ICollection<EmailCompaign> EmailCompaigns { get; set; } = new List<EmailCompaign>();

    public virtual ICollection<Faq> Faqs { get; set; } = new List<Faq>();

    public virtual ICollection<FilePurchasing> FilePurchasings { get; set; } = new List<FilePurchasing>();

    public virtual ICollection<FileSale> FileSales { get; set; } = new List<FileSale>();

    public virtual ICollection<FollowupDetail> FollowupDetails { get; set; } = new List<FollowupDetail>();

    public virtual ICollection<Glreceipt> Glreceipts { get; set; } = new List<Glreceipt>();

    public virtual ICollection<InstallmentPlan> InstallmentPlans { get; set; } = new List<InstallmentPlan>();

    public virtual ICollection<ItemBoqplan> ItemBoqplans { get; set; } = new List<ItemBoqplan>();

    public virtual ICollection<LeadAssignmentSetup> LeadAssignmentSetups { get; set; } = new List<LeadAssignmentSetup>();

    public virtual ICollection<Lead> Leads { get; set; } = new List<Lead>();

    public virtual ICollection<OpenTrading> OpenTradings { get; set; } = new List<OpenTrading>();

    public virtual ICollection<PendingFollowup> PendingFollowups { get; set; } = new List<PendingFollowup>();

    public virtual ICollection<PendingLeadsNew> PendingLeadsNews { get; set; } = new List<PendingLeadsNew>();

    public virtual ICollection<ProjectSale> ProjectSales { get; set; } = new List<ProjectSale>();

    public virtual ICollection<ProjectWiseGl> ProjectWiseGls { get; set; } = new List<ProjectWiseGl>();

    public virtual ICollection<QuotaAllocation> QuotaAllocations { get; set; } = new List<QuotaAllocation>();

    public virtual ICollection<SubProject> SubProjects { get; set; } = new List<SubProject>();

    public virtual ICollection<TokenReceipt> TokenReceipts { get; set; } = new List<TokenReceipt>();

    public virtual ICollection<TradingTokenReceipt> TradingTokenReceipts { get; set; } = new List<TradingTokenReceipt>();

    public virtual ICollection<TradingTokenReturn> TradingTokenReturns { get; set; } = new List<TradingTokenReturn>();

    public virtual ICollection<Trading> Tradings { get; set; } = new List<Trading>();
}
