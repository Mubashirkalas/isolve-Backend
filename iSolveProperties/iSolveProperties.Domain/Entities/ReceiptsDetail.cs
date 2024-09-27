using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ReceiptsDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public short? Sno { get; set; }

    public string? Bpcode { get; set; }

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

    public string? Ipno { get; set; }

    public DateOnly? Ipdate { get; set; }

    public bool? SelectIpno { get; set; }

    public double? IncomeTax { get; set; }

    public double? Whtax { get; set; }

    public short? Ipsrno { get; set; }

    public double? AmountToBeReceived { get; set; }

    public virtual ReceiptsMain? ReceiptsMain { get; set; }
}
