using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DeliveryOrderPartyReturn
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? DoNo { get; set; }

    public short? SNo { get; set; }

    public string? JoNo { get; set; }

    public DateOnly? JoDate { get; set; }

    public byte? SubSegmentIdDetail { get; set; }

    public string? BpCode { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? QytCylinder { get; set; }

    public string? QytCp { get; set; }

    public string? QytMcl { get; set; }

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

    public string? VehicleId { get; set; }

    public double? DeliveryAddress { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public double? CgsValue { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public virtual DeliveryOrderMasterReturn? DeliveryOrderMasterReturn { get; set; }
}
