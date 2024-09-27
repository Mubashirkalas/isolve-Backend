using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwReceiptsMasterDetail
{
    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public bool? Bptype { get; set; }

    public string? PaymentAgainst { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? SuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public short? MuserId { get; set; }

    public DateTime? McreationDate { get; set; }

    public bool? OnAccount { get; set; }

    public short? Sno { get; set; }

    public string? PostedBy { get; set; }

    public string? Docno { get; set; }

    public DateOnly? Docdate { get; set; }

    public string? Doctype { get; set; }

    public byte? SubSegmentIddetail { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? KgQty { get; set; }

    public double? Discounts { get; set; }

    public double? Ltr { get; set; }

    public double? Rate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SalesTax { get; set; }

    public double? SalesTaxPayable { get; set; }

    public double? FutherTax { get; set; }

    public double? TotalValue { get; set; }

    public string? Freight { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? CreditMemoNo { get; set; }

    public DateOnly? CreditMemoDate { get; set; }

    public double? CreditMemoAmount { get; set; }

    public double? TotalNetValue { get; set; }

    public double? AmountReceived { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? ItemName { get; set; }

    public string? GroupName { get; set; }

    public string? SubSegmentName { get; set; }

    public string? Ipno { get; set; }

    public DateOnly? Ipdate { get; set; }

    public string? PaymentMode { get; set; }

    public bool? SelectIpno { get; set; }

    public double? IncomeTax { get; set; }

    public double? Whtax { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public double? ChequeAmount { get; set; }

    public short? Ipsrno { get; set; }

    public double? AmountToBeReceived { get; set; }

    public string? Status { get; set; }

    public string? Address { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Srno { get; set; }

    public string? SubSegmentNameDetail { get; set; }

    public string? AccountNo { get; set; }

    public string? AccountTitle { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? BankName { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }
}
