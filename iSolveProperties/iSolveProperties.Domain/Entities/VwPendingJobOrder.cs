using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingJobOrder
{
    public string? JobOrderNo { get; set; }

    public string? JobOrderDate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? DeliveryDate { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? RouteId { get; set; }

    public string? RouteName { get; set; }

    public string? VehicleNo { get; set; }

    public string ItemGroup { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string ItemCode { get; set; } = null!;

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

    public double? SaleTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public string? Freight { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? Status { get; set; }

    public string? DetailBpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Type { get; set; }
}
