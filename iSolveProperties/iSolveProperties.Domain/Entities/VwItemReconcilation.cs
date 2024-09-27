using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemReconcilation
{
    public double? OpeningPrnQty { get; set; }

    public double? OpeningDsQty { get; set; }

    public double? OpeningCgsQty { get; set; }

    public double? OpeningCgsrQty { get; set; }

    public double? OpeningWcgsQty { get; set; }

    public double? OpeningWcgsrQty { get; set; }

    public double? OpeningDwcgsQty { get; set; }

    public double? OpeningDwcgsrQty { get; set; }

    public double? OpeningDcgsQty { get; set; }

    public double? OpeningDcgsrQty { get; set; }

    public double? OpeningPinQty { get; set; }

    public double? OpeningGrnQty { get; set; }

    public double? OpeningGrnrQty { get; set; }

    public double? OpeningSinQty { get; set; }

    public double? OpeningSinrQty { get; set; }

    public decimal? OpeningGrnValue { get; set; }

    public decimal? OpeningDsValue { get; set; }

    public decimal? OpeningGrnrValue { get; set; }

    public decimal? OpeningSinValue { get; set; }

    public decimal? OpeningCgsValue { get; set; }

    public decimal? OpeningCgsrValue { get; set; }

    public decimal? OpeningWcgsValue { get; set; }

    public decimal? OpeningWcgsrValue { get; set; }

    public decimal? OpeningDcgsValue { get; set; }

    public decimal? OpeningDcgsrValue { get; set; }

    public decimal? OpeningDwcgsValue { get; set; }

    public decimal? OpeningDwcgsrValue { get; set; }

    public decimal? OpeningSinrValue { get; set; }

    public decimal? OpeningPrnValue { get; set; }

    public decimal? OpeningPinValue { get; set; }

    public double? GrnQty { get; set; }

    public double? DsQty { get; set; }

    public double? GrnrQty { get; set; }

    public double? SinQty { get; set; }

    public double? CgsQty { get; set; }

    public double? CgsrQty { get; set; }

    public double? WcgsQty { get; set; }

    public double? WcgsrQty { get; set; }

    public double? DcgsQty { get; set; }

    public double? DcgsrQty { get; set; }

    public double? DwcgsQty { get; set; }

    public double? DwcgsrQty { get; set; }

    public double? SinrQty { get; set; }

    public double? PinQty { get; set; }

    public double? PrnQty { get; set; }

    public decimal? GrnValue { get; set; }

    public decimal? DsValue { get; set; }

    public decimal? GrnrValue { get; set; }

    public decimal? SinValue { get; set; }

    public decimal? CgsValue { get; set; }

    public decimal? CgsrValue { get; set; }

    public decimal? DcgsValue { get; set; }

    public decimal? DcgsrValue { get; set; }

    public decimal? WcgsValue { get; set; }

    public decimal? WcgsrValue { get; set; }

    public decimal? DwcgsValue { get; set; }

    public decimal? DwcgsrValue { get; set; }

    public decimal? SinrValue { get; set; }

    public decimal? PrnValue { get; set; }

    public decimal? PinValue { get; set; }

    public string ItCode { get; set; } = null!;

    public short? SubSegmentId { get; set; }

    public byte CompId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Whname { get; set; }

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public string? Uom { get; set; }

    public string ItemCode { get; set; } = null!;
}
