using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDopartyReturn
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public short? SNo { get; set; }

    public string? JoNo { get; set; }

    public string? JoDate { get; set; }

    public byte? SubSegmentIdDetail { get; set; }

    public string? SubSegmentName { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? QytCylinder { get; set; }

    public double? QytM3 { get; set; }

    public double? QytKg { get; set; }

    public double? QytLiter { get; set; }

    public double? Unitrate { get; set; }

    public string? InvoiceValue { get; set; }

    public string? SalesTax { get; set; }

    public string? FurtherTax { get; set; }

    public string? TotalValue { get; set; }

    public string? Freight { get; set; }

    public double? FreightPerUnit { get; set; }

    public string? TotalFreight { get; set; }

    public string? TotalInvoiceValue { get; set; }

    public string? RouteId { get; set; }

    public string? RouteName { get; set; }

    public string? VehicleId { get; set; }

    public double? DeliveryAddress { get; set; }

    public string? DeliveryDate { get; set; }

    public string? QytCp { get; set; }

    public string? QytMcl { get; set; }

    public string? Remarks { get; set; }

    public string? Category { get; set; }

    public string? Name { get; set; }

    public DateOnly? DoDate { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }
}
