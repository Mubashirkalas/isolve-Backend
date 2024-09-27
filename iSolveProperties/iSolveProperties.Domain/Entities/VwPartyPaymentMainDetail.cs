using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPartyPaymentMainDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public double? AdvanceBal { get; set; }

    public double? InvoiceBal { get; set; }

    public double? SecurityBal { get; set; }

    public double? ApAccuralBal { get; set; }

    public double? NetBal { get; set; }

    public string? BpType { get; set; }

    public string? PaymentAgainst { get; set; }

    public string? PaymentMode { get; set; }

    public string? AcNo { get; set; }

    public string? CheqSlipNo { get; set; }

    public DateOnly? CheqSlipDate { get; set; }

    public double? CheqAmount { get; set; }

    public bool? PaymentOnAccount { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public short? Sno { get; set; }

    public bool? Select { get; set; }

    public string? DocNo { get; set; }

    public string? DocType { get; set; }

    public DateOnly? DocDate { get; set; }

    public DateOnly? PostingDate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? AmountPayable { get; set; }

    public double? CashDiscount { get; set; }

    public double? SalesTax { get; set; }

    public double? TotalPayment { get; set; }

    public double? AmountToBePaid { get; set; }

    public string? IpNo { get; set; }

    public double? AmountPaid { get; set; }

    public double? AdvanceIncomeTax { get; set; }

    public string? Tel1 { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? CName { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Expr1 { get; set; }

    public string? Expr2 { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? RegisteredOfficeAdress { get; set; }

    public string? BankName { get; set; }
}
