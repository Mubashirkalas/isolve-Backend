using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSinmasterDetail
{
    public string? Grnno { get; set; }

    public string? Type { get; set; }

    public string? GrnDate { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Srno { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public byte? SubSegmentCode { get; set; }

    public double? PurchaseQty { get; set; }

    public string? Uom { get; set; }

    public string? Rate { get; set; }

    public decimal? Value { get; set; }

    public string? TotalValue { get; set; }

    public byte? WarehouseNo { get; set; }

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

    public string? RemainingQty { get; set; }

    public string? DrRequisitionDate { get; set; }

    public byte? ToWareHouseSubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public double? TransportationCharges { get; set; }

    public string? VehicleRegistration { get; set; }

    public string? DrRequisition { get; set; }

    public string? IssueQty { get; set; }

    public string? DeptCode { get; set; }

    public string? CcDesc { get; set; }

    public string SubSegmentName1 { get; set; } = null!;

    public string SubSegmentNameMain { get; set; } = null!;

    public DateOnly? Grndate1 { get; set; }

    public string? VehicleId { get; set; }

    public double DemandQty { get; set; }

    public byte? ToWareHouseNo { get; set; }

    public double? OtherOverheads { get; set; }

    public string? ToWhName { get; set; }

    public string? TotalValues { get; set; }

    public double RemainingQtys { get; set; }

    public short? DetailSrno { get; set; }

    public string? Remarks { get; set; }

    public double? SerialNo { get; set; }

    public string? GrnReturnNo { get; set; }

    public decimal? TotalValue1 { get; set; }
}
