using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSaleOrderMainDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SaleNo { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public int? Qty { get; set; }

    public double? Rate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SaleTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public string? Name { get; set; }

    public double ReceivedQty { get; set; }

    public DateOnly? SaleDate { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? SubSegmentName { get; set; }

    public string? ItDesc { get; set; }

    public string? Remarks { get; set; }

    public string? ItemName { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public string? Brand { get; set; }

    public string? Category { get; set; }
}
