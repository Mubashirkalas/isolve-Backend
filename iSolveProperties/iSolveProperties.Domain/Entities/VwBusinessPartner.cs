using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBusinessPartner
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

    public double? Wht150 { get; set; }

    public double? WhtSalesTax { get; set; }

    public double? WhtFurtherTax { get; set; }

    public string? Remarks { get; set; }

    public byte CompId { get; set; }

    public string? ControlAccountPaymentInAdvance { get; set; }

    public string? ControlAccountPaymentInAdvanceDesc { get; set; }

    public string? ControlAccountInvoice { get; set; }

    public string? ControlAccountInvoiceDesc { get; set; }

    public string? ControlAccountCashDiscount { get; set; }

    public string? ControlAccountCashDiscountDesc { get; set; }

    public string BpType { get; set; } = null!;

    public double? InvoiceOpeningBalance { get; set; }

    public double? SecurityOpeningBalance { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? ControlAccountApaccural { get; set; }

    public string? ControlAccountSecurity { get; set; }

    public string? Apname { get; set; }

    public string? SecurityName { get; set; }

    public string? ControlAccountIncomeTax { get; set; }

    public string? ControlAccountIncomeTaxName { get; set; }

    public string? ControlAccountSalesTax { get; set; }

    public string? ControlAccountSalesTaxName { get; set; }

    public string? ControlAccountFurtherTax { get; set; }

    public string? ControlAccountFurtherTaxName { get; set; }

    public bool? Status { get; set; }

    public string? ControlAccountCash { get; set; }

    public string? ControlAccountOther { get; set; }

    public string? Test1 { get; set; }

    public string? Test2 { get; set; }

    public string? Test3 { get; set; }

    public string? Test4 { get; set; }

    public string? ControlAccountCashDescription { get; set; }

    public string? ControlAccountOtherDescription { get; set; }

    public string? Test1Description { get; set; }

    public string? Test2Description { get; set; }

    public string? Test3Description { get; set; }

    public string? Test4Description { get; set; }

    public string? OldCustomerCode { get; set; }

    public string? SalesManName { get; set; }

    public string? RegionName { get; set; }

    public string? OwnedorRented { get; set; }

    public string? Cnic { get; set; }

    public string? SecurityChequeNo { get; set; }

    public DateOnly? Dob { get; set; }

    public string? TradingReceivable { get; set; }

    public string? TradingReceivableDescription { get; set; }

    public string? InstrumentReceivable { get; set; }

    public string? InstrumentReceivableDescription { get; set; }

    public string? GeneralOne { get; set; }

    public string? GeneralOneDescription { get; set; }

    public string? Bpuserid { get; set; }

    public string? Bppassword { get; set; }

    public string? TaxStatus { get; set; }

    public int? FilerTax { get; set; }

    public int? NonFilerTax { get; set; }
}
