using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemLedger
{
    public double? OpeningPrnQty { get; set; }

    public double? OpeningDcgsQty { get; set; }

    public double? OpeningDwcgsQty { get; set; }

    public double? OpeningDcgsrQty { get; set; }

    public double? OpeningWcgsQty { get; set; }

    public double? OpeningWcgsrQty { get; set; }

    public double? OpeningDwcgsrQty { get; set; }

    public double? OpeningPinQty { get; set; }

    public string ItCode { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public string SubSegmentName { get; set; } = null!;

    public string? Whname { get; set; }

    public string? ItemName { get; set; }

    public double? OpeningGrnQty { get; set; }

    public double? OpeningGrnrQty { get; set; }

    public double? OpeningSinQty { get; set; }

    public double? OpeningCgsrQty { get; set; }

    public double? OpeningCgsQty { get; set; }

    public double? OpeningSinrQty { get; set; }

    public double? OpeningDcgsValue { get; set; }

    public double? OpeningDwcgsValue { get; set; }

    public double? Opening { get; set; }

    public double? OpeningDcgsrValue { get; set; }

    public double? OpeningWcgsValue { get; set; }

    public double? OpeningWcgsrValue { get; set; }

    public double? OpeningDwcgsrValue { get; set; }

    public double? OpeningGrnValue { get; set; }

    public double? OpeningGrnrValue { get; set; }

    public double? OpeningSinValue { get; set; }

    public double? OpeningCgsrValue { get; set; }

    public double? OpeningCgsValue { get; set; }

    public double? OpeningSinrValue { get; set; }

    public double? OpeningPrnValue { get; set; }

    public double? OpeningPinValue { get; set; }

    public double? PurchaseQty { get; set; }

    public double? IssueQty { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Keys { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? TotalValue { get; set; }

    public byte? WarehouseNo { get; set; }

    public double? TotalSinValue { get; set; }

    public string? DeptCode { get; set; }

    public string? VehicleId { get; set; }

    public string? ItDesc { get; set; }

    public string? SubSegmentNameMain { get; set; }

    public string? Grnno { get; set; }

    public string? Type { get; set; }

    public DateOnly? GrnDate1 { get; set; }

    public DateOnly? Expr1 { get; set; }
}
