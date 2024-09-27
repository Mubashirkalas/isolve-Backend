using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDosalesComparison
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

    public string? QytCp { get; set; }

    public string? QytMcl { get; set; }

    public byte SubSegmentId { get; set; }

    public string DoNo { get; set; } = null!;

    public string? Remarks { get; set; }

    public string? DeliveryAddress2 { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public DateOnly? DoDate { get; set; }
}
