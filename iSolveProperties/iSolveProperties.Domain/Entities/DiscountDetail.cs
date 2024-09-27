using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DiscountDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? DiNo { get; set; }

    public short? Sno { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? NormalDiscount { get; set; }

    public double? ProceduralDiscount { get; set; }

    public double? PromotionalDiscount { get; set; }

    public double? SeasonalDiscount { get; set; }

    public double? SpecialDiscount { get; set; }

    public virtual DiscountsMain? DiscountsMain { get; set; }
}
