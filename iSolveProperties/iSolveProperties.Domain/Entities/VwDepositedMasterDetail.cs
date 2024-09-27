using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDepositedMasterDetail
{
    public string Srno { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public double? ChequeAmount { get; set; }

    public string? DepositedIn { get; set; }

    public DateOnly? DepositedDate { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public short? Sno { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? ReceiptNo { get; set; }

    public DateOnly? ReceiptDate { get; set; }

    public byte? DetailSubSegmentId { get; set; }

    public string DetailSubSegmentName { get; set; } = null!;

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

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

    public string? AccountTitle { get; set; }

    public double? AmountTobeReceived { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchName { get; set; }

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }
}
