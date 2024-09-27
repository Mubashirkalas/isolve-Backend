using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDeliveryOrderMainDetail
{
    public string SubSegmentName { get; set; } = null!;

    public string? GroupName { get; set; }

    public string? Itemname { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Unitrate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SalesTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public double? FreightPerUnit { get; set; }

    public string? Freight { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? RouteId { get; set; }

    public string? VehicleId { get; set; }

    public string? DeliveryAddress { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public double? Cgsvalue { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? DeliveryAddress2 { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Fyear { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string Dono { get; set; } = null!;

    public DateOnly? Dodate { get; set; }

    public string? Type { get; set; }

    public short? Userid { get; set; }

    public string? Workstation { get; set; }

    public string? Username { get; set; }

    public DateTime? CreationDate { get; set; }

    public short? ModifiedUserId { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public string? ModifiedUsername { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? CommissionAgent { get; set; }

    public string? Bpcode { get; set; }

    public bool? DirectArrangement { get; set; }

    public string? ContactNo { get; set; }

    public string? BuiltyNo { get; set; }

    public DateOnly? BuiltyDate { get; set; }

    public double? BuiltyAmount { get; set; }

    public string? DeliveryArrangement { get; set; }

    public string? PaidBy { get; set; }

    public double ReturnQty { get; set; }

    public string? PartyType { get; set; }

    public double? QtyKg { get; set; }

    public double? QtyCylinder { get; set; }

    public double? TotalValue1 { get; set; }

    public string? Region { get; set; }

    public byte CompId1 { get; set; }

    public string? Name { get; set; }

    public string? PhoneNo { get; set; }

    public string? RouteName { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public string? Brand { get; set; }

    public string? Category { get; set; }
}
