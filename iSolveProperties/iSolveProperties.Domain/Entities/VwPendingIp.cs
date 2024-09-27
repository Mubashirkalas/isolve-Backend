using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingIp
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte SubSegmentIddetail { get; set; }

    public string SubSegmentNameDetail { get; set; } = null!;

    public string Ipno { get; set; } = null!;

    public DateOnly? Ipdate { get; set; }

    public string Bpcode { get; set; } = null!;

    public string? Bpname { get; set; }

    public short? Sno { get; set; }

    public string? PostedBy { get; set; }

    public string? Docno { get; set; }

    public DateOnly? Docdate { get; set; }

    public string? Doctype { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? KgQty { get; set; }

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

    public string? Status { get; set; }

    public double AmountToBeReceived { get; set; }

    public double? Discounts { get; set; }
}
