using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BusinessPartnersMain
{
    public string BusinessPartnersCode { get; set; } = null!;

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Cellno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Sector { get; set; }

    public string? ReferedBy { get; set; }

    public string? PartyType { get; set; }

    public string? Website { get; set; }

    public string? Ntn { get; set; }

    public string? Strn { get; set; }

    public string? LegalStatus { get; set; }

    public string? City { get; set; }

    public string? Region { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }

    public string? RegisteredOfficeAdress { get; set; }

    public bool? Cash { get; set; }

    public bool? Cheque { get; set; }

    public bool? Lc { get; set; }

    public bool? PaymentInAdvance { get; set; }

    public bool? PaymentAfterDelivery { get; set; }

    public double? CreditLimitAmount { get; set; }

    public double? CreditLimitDays { get; set; }

    public string? CreditLimitAmountCondition { get; set; }

    public string? CreditLimitDaysCondition { get; set; }

    public double? TradeDiscount { get; set; }

    public double? CashDiscountPercentage { get; set; }

    public double? CashDiscountDays { get; set; }

    public string? ControlAccountPaymentInAdvance { get; set; }

    public string? ControlAccountInvoice { get; set; }

    public string? ControlAccountCashDiscount { get; set; }

    public double? Wht150 { get; set; }

    public double? WhtSalesTax { get; set; }

    public double? WhtFurtherTax { get; set; }

    public string? Remarks { get; set; }

    public byte CompId { get; set; }

    public string BpType { get; set; } = null!;

    public double? InvoiceOpeningBalance { get; set; }

    public double? SecurityOpeningBalance { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? ControlAccountApaccural { get; set; }

    public string? ControlAccountSecurity { get; set; }

    public string? ControlAccountIncomeTax { get; set; }

    public string? ControlAccountSalesTax { get; set; }

    public string? ControlAccountFurtherTax { get; set; }

    public bool? Status { get; set; }

    public string? ControlAccountCash { get; set; }

    public string? ControlAccountOther { get; set; }

    public string? Test1 { get; set; }

    public string? Test2 { get; set; }

    public string? Test3 { get; set; }

    public string? Test4 { get; set; }

    public string? OldCustomerCode { get; set; }

    public string? OwnedorRented { get; set; }

    public string? Cnic { get; set; }

    public string? SecurityChequeNo { get; set; }

    public DateOnly? Dob { get; set; }

    public string? TradingReceivable { get; set; }

    public string? InstrumentReceivable { get; set; }

    public string? GeneralOne { get; set; }

    public string? Bpuserid { get; set; }

    public string? Bppassword { get; set; }

    public string? TaxStatus { get; set; }

    public int? FilerTax { get; set; }

    public int? NonFilerTax { get; set; }

    public virtual ICollection<AssetPartialPayment> AssetPartialPayments { get; set; } = new List<AssetPartialPayment>();

    public virtual ICollection<BookingForm> BookingFormBusinessPartnersMainNavigations { get; set; } = new List<BookingForm>();

    public virtual ICollection<BookingForm> BookingFormBusinessPartnersMains { get; set; } = new List<BookingForm>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();

    public virtual ICollection<DealPurchaseModified> DealPurchaseModifieds { get; set; } = new List<DealPurchaseModified>();

    public virtual ICollection<DealPurchase> DealPurchases { get; set; } = new List<DealPurchase>();

    public virtual ICollection<DealerQuotum> DealerQuota { get; set; } = new List<DealerQuotum>();

    public virtual ICollection<DeliveryDispatchMaster> DeliveryDispatchMasters { get; set; } = new List<DeliveryDispatchMaster>();

    public virtual ICollection<DiscountPosting> DiscountPostings { get; set; } = new List<DiscountPosting>();

    public virtual ICollection<FileDeliveryConfirmation> FileDeliveryConfirmations { get; set; } = new List<FileDeliveryConfirmation>();

    public virtual ICollection<FileInventory> FileInventories { get; set; } = new List<FileInventory>();

    public virtual ICollection<FilePurchasing> FilePurchasings { get; set; } = new List<FilePurchasing>();

    public virtual ICollection<FileSale> FileSales { get; set; } = new List<FileSale>();

    public virtual ICollection<FormsReturn> FormsReturns { get; set; } = new List<FormsReturn>();

    public virtual ICollection<Glreceipt> Glreceipts { get; set; } = new List<Glreceipt>();

    public virtual ICollection<InBoundInventory> InBoundInventories { get; set; } = new List<InBoundInventory>();

    public virtual ICollection<InvestorDetail> InvestorDetailBusinessPartnersMainNavigations { get; set; } = new List<InvestorDetail>();

    public virtual ICollection<InvestorDetail> InvestorDetailBusinessPartnersMains { get; set; } = new List<InvestorDetail>();

    public virtual ICollection<InvestorRegistration> InvestorRegistrations { get; set; } = new List<InvestorRegistration>();

    public virtual ICollection<IpMain> IpMains { get; set; } = new List<IpMain>();

    public virtual ICollection<OpenTrading> OpenTradingBusinessPartnersMain1s { get; set; } = new List<OpenTrading>();

    public virtual ICollection<OpenTrading> OpenTradingBusinessPartnersMainNavigations { get; set; } = new List<OpenTrading>();

    public virtual ICollection<OpenTrading> OpenTradingBusinessPartnersMains { get; set; } = new List<OpenTrading>();

    public virtual ICollection<PartialAdjustment> PartialAdjustments { get; set; } = new List<PartialAdjustment>();

    public virtual ICollection<PartialReceipt> PartialReceipts { get; set; } = new List<PartialReceipt>();

    public virtual ICollection<PaymentPlan> PaymentPlans { get; set; } = new List<PaymentPlan>();

    public virtual ICollection<Pomaster> Pomasters { get; set; } = new List<Pomaster>();

    public virtual ICollection<ProjectSale> ProjectSaleBusinessPartnersMain1s { get; set; } = new List<ProjectSale>();

    public virtual ICollection<ProjectSale> ProjectSaleBusinessPartnersMainNavigations { get; set; } = new List<ProjectSale>();

    public virtual ICollection<ProjectSale> ProjectSaleBusinessPartnersMains { get; set; } = new List<ProjectSale>();

    public virtual ICollection<ProjectSaleFileDelivery> ProjectSaleFileDeliveries { get; set; } = new List<ProjectSaleFileDelivery>();

    public virtual ICollection<ProjectTransfer> ProjectTransferBusinessPartnersMainNavigations { get; set; } = new List<ProjectTransfer>();

    public virtual ICollection<ProjectTransfer> ProjectTransferBusinessPartnersMains { get; set; } = new List<ProjectTransfer>();

    public virtual ICollection<QuotaAllocationDetail> QuotaAllocationDetails { get; set; } = new List<QuotaAllocationDetail>();

    public virtual ICollection<QuotationMaster> QuotationMasters { get; set; } = new List<QuotationMaster>();

    public virtual ICollection<TeamSetup> TeamSetups { get; set; } = new List<TeamSetup>();

    public virtual ICollection<TradingReceiptsPayment> TradingReceiptsPayments { get; set; } = new List<TradingReceiptsPayment>();

    public virtual ICollection<UserAndPartyMaping> UserAndPartyMapings { get; set; } = new List<UserAndPartyMaping>();

    public virtual ICollection<VendorCommission> VendorCommissions { get; set; } = new List<VendorCommission>();
}
