using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBomLiquid
{
    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public double? LiquidConversionCost { get; set; }

    public string? LUom { get; set; }

    public byte? SubSegmentId { get; set; }

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? LiquidGroupCode { get; set; }

    public string? LiquidItemCode { get; set; }

    public string? LiquidUom { get; set; }

    public double? LiquidQty { get; set; }

    public string? ItemName { get; set; }

    public string? Itemname1 { get; set; }
}
