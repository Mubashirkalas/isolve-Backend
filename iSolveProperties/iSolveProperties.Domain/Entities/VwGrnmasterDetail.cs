using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGrnmasterDetail
{
    public int? Grnno { get; set; }

    public string? Type { get; set; }

    public string? GrnDate { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? Srno { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public short? SubSegmentCode { get; set; }

    public string SubSegmentName1 { get; set; } = null!;

    public double? PurchaseQty { get; set; }

    public string? Uom { get; set; }

    public decimal? NetPurchaseRate { get; set; }

    public decimal? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public decimal? TotalValue { get; set; }

    public int? Igpno { get; set; }

    public string? IgpDate { get; set; }

    public int? Pono { get; set; }

    public string? PoDate { get; set; }

    public string? Dcno { get; set; }

    public string? ExpiryDate { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public short? WarehouseNo { get; set; }

    public string? Whname { get; set; }

    public short? Sno { get; set; }

    public string? Address { get; set; }

    public string? CAbber { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? CreationDate { get; set; }

    public DateTime? TrCreationDate { get; set; }

    public decimal RemainingValue { get; set; }

    public decimal RemainingRate { get; set; }

    public double RemainingQty { get; set; }

    public string? PartyType { get; set; }

    public DateOnly? Grndate1 { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public double? ExciseValue { get; set; }

    public double? SalesTaxReceivable { get; set; }

    public decimal? Rate { get; set; }

    public long SerialNo { get; set; }

    public int? GrnReturnNo { get; set; }

    public string? Recievername { get; set; }

    public string? CompanyName { get; set; }

    public decimal? FreightAmount { get; set; }

    public DateOnly? BuiltyDate { get; set; }

    public string? BuiltyNo { get; set; }

    public string? DeptCode { get; set; }

    public byte? ToWareHouseNo { get; set; }

    public byte? ToWareHouseSubSegmentId { get; set; }

    public string? ToWhName { get; set; }

    public double? QtyInStock { get; set; }

    public double? TransportationCharges { get; set; }

    public double? OtherOverheads { get; set; }

    public string? VehicleId { get; set; }

    public DateOnly? Expr1 { get; set; }

    public string? Igptype { get; set; }
}
