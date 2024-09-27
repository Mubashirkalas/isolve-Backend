using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempDoforIp
{
    public bool? SelectCheck { get; set; }

    public short? Srno { get; set; }

    public string? DoNo { get; set; }

    public DateOnly? DoDate { get; set; }

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

    public string? RouteId { get; set; }

    public string? RouteName { get; set; }

    public string? VehicleId { get; set; }

    public string? DeliveryAddress { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public short? UserId { get; set; }

    public double? CgsValue { get; set; }

    public DateOnly? WarrantyDate { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public string? Particulars { get; set; }

    public string? Status { get; set; }
}
