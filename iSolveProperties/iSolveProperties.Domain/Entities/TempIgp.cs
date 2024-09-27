using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempIgp
{
    public bool? SelectCheck { get; set; }

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public string? IgpNo { get; set; }

    public DateOnly? IgpDate { get; set; }

    public double? IgpQty { get; set; }

    public string? PoNo { get; set; }

    public DateOnly? PoDate { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public short? UserId { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }

    public string? Dcno { get; set; }

    public DateOnly? DcDate { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public string? Type { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExciseDuty { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTaxValue { get; set; }
}
