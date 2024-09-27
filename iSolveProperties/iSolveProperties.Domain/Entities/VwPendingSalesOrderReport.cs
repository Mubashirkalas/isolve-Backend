using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingSalesOrderReport
{
    public string? SaleNo { get; set; }

    public DateOnly? SaleDate { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? ItemGroup { get; set; }

    public short? Sno { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public int? CylindersQyt { get; set; }

    public double? M3Qty { get; set; }

    public double? UnitRate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public double? Purity { get; set; }

    public double? SaleTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public double? Discount { get; set; }

    public string? Srno { get; set; }

    public DateOnly? WarrantyDate { get; set; }

    public double? DiscountValue { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public double? ApprovedQty { get; set; }

    public byte CompId { get; set; }
}
