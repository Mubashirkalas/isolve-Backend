using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWDeliveryOrderMainDetailReport
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string? SubSegmentNameMain { get; set; }

    public string DoNo { get; set; } = null!;

    public DateOnly? DoDate { get; set; }

    public short? SNo { get; set; }

    public string? JoNo { get; set; }

    public DateOnly? JoDate { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public byte? SubSegmentIdDetail { get; set; }

    public string? SubSegmentNameDetail { get; set; }

    public double? QytCylinder { get; set; }

    public double? QytM3 { get; set; }

    public double? QytKg { get; set; }

    public double? QytLiter { get; set; }

    public double? Unitrate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SalesTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? RouteId { get; set; }

    public string? RouteName { get; set; }

    public string? Mileage { get; set; }

    public string? Time { get; set; }

    public bool? TimeType { get; set; }

    public string? VehicleId { get; set; }

    public string? ClassOfVehicle { get; set; }

    public string? TypeOfBody { get; set; }

    public string? TypeOfVehicle { get; set; }

    public double? MaximumLoad { get; set; }

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? CphoneNo { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Levels { get; set; }

    public DateOnly? Vdate { get; set; }

    public string? Expr1 { get; set; }

    public string? Freight { get; set; }

    public string? DeliveryAddress { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? Uom { get; set; }

    public string? FaxBp { get; set; }

    public string? EmailBp { get; set; }

    public string? Tel1 { get; set; }

    public string? PartyType { get; set; }

    public string? ContactPerson { get; set; }

    public string? Remarks { get; set; }

    public string? Username { get; set; }

    public string? BpCode { get; set; }

    public string? DeliveryAddress2 { get; set; }

    public string? ContactNo { get; set; }

    public string? PhoneNo { get; set; }

    public short? Userid { get; set; }

    public string? UserName1 { get; set; }

    public string? Particulars { get; set; }
}
