using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDiscountMainDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public byte SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string PpNo { get; set; } = null!;

    public short? Sno { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? NormalDiscount { get; set; }

    public double? ProceduralDiscount { get; set; }

    public double? PromotionalDiscount { get; set; }

    public double? SeasonalDiscount { get; set; }

    public double? SpecialDiscount { get; set; }
}
