using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDeliveryOrderReturnDetails1
{
    public string? Region { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? DoreturnNo { get; set; }

    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Fyear { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? Dono { get; set; }

    public short? Sno { get; set; }

    public string? Bpcode { get; set; }

    public double? Qty { get; set; }

    public double? Unitrate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SalesTax { get; set; }

    public double? FurtherTax { get; set; }

    public string? Freight { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public double? TotalFreight { get; set; }

    public double? DeliveryAddress { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? GroupName { get; set; }

    public string GroupCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public DateOnly? Dodate { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public string? PartyType { get; set; }

    public string? Uom { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public double? TotalValue { get; set; }

    public double? QytCylinder { get; set; }

    public string? Brand { get; set; }

    public string? Category { get; set; }
}
