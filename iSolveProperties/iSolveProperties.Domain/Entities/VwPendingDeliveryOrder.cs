using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingDeliveryOrder
{
    public string DoNo { get; set; } = null!;

    public string? DoDate { get; set; }

    public byte? SubSegmentIdDetail { get; set; }

    public string SubSegmentNameDetail { get; set; } = null!;

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string ItemGroup { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? QytCylinder { get; set; }

    public double? QytM3 { get; set; }

    public double? QytKg { get; set; }

    public double? QytLiter { get; set; }

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

    public string? DeliveryDate { get; set; }

    public string FYear { get; set; } = null!;

    public byte CompId { get; set; }

    public string Srno { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public double? CgsValue { get; set; }

    public DateOnly? WarrantyDate { get; set; }

    public string? DeliveryAddress2 { get; set; }

    public string? Remarks { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public string? Status { get; set; }

    public DateOnly? Dodate1 { get; set; }

    public string? Particulars { get; set; }
}
