using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWIpReport
{
    public short? Sno { get; set; }

    public string? PostedBy { get; set; }

    public string? DocNo { get; set; }

    public string? DocDate { get; set; }

    public string? DocType { get; set; }

    public byte? SubSegmentIdDetail { get; set; }

    public string? SubSegmentNameDetail { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? CylinderQty { get; set; }

    public double? M3Qty { get; set; }

    public double? KgQty { get; set; }

    public double? LtrQty { get; set; }

    public double? UnitRate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SalesTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public string? Freight { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? CreditMemoNo { get; set; }

    public string? CreditMemoDate { get; set; }

    public double? CreditMemoAmount { get; set; }

    public double? TotalNetValue { get; set; }

    public string? RouteId { get; set; }

    public string? VehicleId { get; set; }

    public string? DeliveryDate { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? RouteName { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string IpNo { get; set; } = null!;

    public string BpCode { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public DateOnly? IpDate { get; set; }

    public string? PartyType { get; set; }

    public double? AdvanceBal { get; set; }

    public double? InvoiceBal { get; set; }

    public double? SecurityBal { get; set; }

    public double? ApaccuralBal { get; set; }

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Levels { get; set; }

    public DateOnly? Vdate { get; set; }

    public double? SalesTaxPayable { get; set; }

    public string? NtnOfParty { get; set; }

    public string? Strn { get; set; }

    public string? RegisteredOfficeAdress { get; set; }

    public double? CgsValue { get; set; }

    public string? ItemDescription { get; set; }

    public string? Particulars { get; set; }

    public string? Brand { get; set; }

    public string? Vendor { get; set; }
}
