using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempReceipt
{
    public bool? SelectCheck { get; set; }

    public short? Srno { get; set; }

    public string? ReceiptNo { get; set; }

    public DateOnly? ReceiptDate { get; set; }

    public byte? SubSegmentIdDetail { get; set; }

    public string? SubSegmentNameDetail { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? QtyCylinder { get; set; }

    public double? QtyM3 { get; set; }

    public double? QtyKg { get; set; }

    public double? QtyLiter { get; set; }

    public double? Unitrate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SalesTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public string? Freight { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public short? UserId { get; set; }

    public string? CreditMemoNo { get; set; }

    public DateOnly? CreditMemoDate { get; set; }

    public double? CreditAmount { get; set; }

    public double? SalesTaxPayable { get; set; }

    public double? _15Salestax { get; set; }

    public double? WhtTax { get; set; }

    public double? TotalNetValue { get; set; }

    public double? AmountReceived { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public double? ChequeAmount { get; set; }

    public double? AmountTobeReceived { get; set; }
}
