using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWSalesOrderReport
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? SaleNo { get; set; }

    public DateOnly? SaleDate { get; set; }

    public string? SaleType { get; set; }

    public string? BpCode { get; set; }

    public string? QuotNo { get; set; }

    public string? ContactPerson { get; set; }

    public string? Designation { get; set; }

    public string? Department { get; set; }

    public string? ModeOfShipment { get; set; }

    public double? DeliveryTime { get; set; }

    public string? Per { get; set; }

    public string? Freight { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? SendingInvoiceTo { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Levels { get; set; }

    public DateOnly? Vdate { get; set; }

    public short? Sno { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public string? Specification { get; set; }

    public double? Purity { get; set; }

    public int? CylindersQyt { get; set; }

    public double? M3Qty { get; set; }

    public double? KgQty { get; set; }

    public double? LtrQty { get; set; }

    public double? UnitRate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SaleTax1 { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? Status { get; set; }

    public string? Bpfax { get; set; }

    public string? Bpemail { get; set; }

    public string? Tel1 { get; set; }

    public DateOnly? Date { get; set; }

    public bool? PaymentInAdvance { get; set; }

    public bool? PaymentAfterDelivery { get; set; }

    public bool? Lc { get; set; }

    public bool? Cheque { get; set; }

    public bool? Cash { get; set; }

    public string? UserName { get; set; }
}
