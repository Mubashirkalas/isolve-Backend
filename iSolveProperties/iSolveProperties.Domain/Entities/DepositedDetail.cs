using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DepositedDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public short? Sno { get; set; }

    public string? BpCode { get; set; }

    public string? ReceiptNo { get; set; }

    public DateOnly? ReceiptDate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? CylinderQty { get; set; }

    public double? KgQty { get; set; }

    public double? M3 { get; set; }

    public double? Ltr { get; set; }

    public double? UnitRate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SalesTax { get; set; }

    public double? SalesTaxPayable { get; set; }

    public double? FuthurTax { get; set; }

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

    public double? IncomeTax { get; set; }

    public double? WhTax { get; set; }

    public double? AmountTobeReceived { get; set; }

    public virtual DepositedMain? DepositedMain { get; set; }
}
