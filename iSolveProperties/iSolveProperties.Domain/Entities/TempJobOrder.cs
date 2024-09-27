using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempJobOrder
{
    public bool? SelectCheck { get; set; }

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public string? JoNo { get; set; }

    public DateOnly? JoDate { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public short? UserId { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public string? Specification { get; set; }

    public string? Purity { get; set; }

    public double? CylindersQyt { get; set; }

    public double? M3Qty { get; set; }

    public double? KgQty { get; set; }

    public double? LtrQty { get; set; }

    public double? UnitRate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SaleTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? Freight { get; set; }

    public string? RouteId { get; set; }

    public string? RouteName { get; set; }

    public string? VehicleNo { get; set; }

    public string? DeliveryAddress { get; set; }

    public DateOnly? DeliveryDate { get; set; }
}
