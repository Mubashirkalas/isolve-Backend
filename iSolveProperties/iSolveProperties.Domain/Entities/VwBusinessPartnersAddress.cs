using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBusinessPartnersAddress
{
    public int? Sno { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Province { get; set; }

    public string? Country { get; set; }

    public string? RegionId { get; set; }

    public string? RouteName { get; set; }

    public string? ContactPerson { get; set; }

    public string? BusinessPartnersName { get; set; }

    public byte CompId { get; set; }

    public string? PartyType { get; set; }

    public string RegionName { get; set; } = null!;

    public string CellNo { get; set; } = null!;

    public double? CreditLimitAmount { get; set; }

    public string BpType { get; set; } = null!;

    public string BusinessPartnersCode { get; set; } = null!;

    public string? GlYear { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Cellno1 { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Sector { get; set; }

    public string? ReferedBy { get; set; }

    public string? Website { get; set; }

    public string? Ntn { get; set; }

    public string? Strn { get; set; }

    public string? LegalStatus { get; set; }

    public string? RegisteredOfficeAdress { get; set; }

    public bool? Cash { get; set; }

    public bool? Cheque { get; set; }

    public bool? Lc { get; set; }

    public bool? PaymentInAdvance { get; set; }

    public bool? PaymentAfterDelivery { get; set; }

    public double? CreditLimitDays { get; set; }

    public string? CreditLimitDaysCondition { get; set; }

    public string? CreditLimitAmountCondition { get; set; }

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

    public double? InvoiceOpeningBalance { get; set; }

    public double? SecurityOpeningBalance { get; set; }

    public string? ControlAccountApaccural { get; set; }

    public string? ControlAccountSecurity { get; set; }

    public string? ControlAccountIncomeTax { get; set; }

    public string? ControlAccountSalesTax { get; set; }

    public string? ControlAccountFurtherTax { get; set; }

    public bool? Status { get; set; }

    public string? ControlAccountCash { get; set; }

    public string? ControlAccountOther { get; set; }

    public string? Test3 { get; set; }

    public string? Test4 { get; set; }

    public string? Test1 { get; set; }

    public string? Test2 { get; set; }

    public string? SecurityChequeNo { get; set; }

    public DateOnly? Dob { get; set; }
}
