using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CfsLiquid
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public int? CsfNo { get; set; }

    public short? Sno { get; set; }

    public string? LiquidGroupCode { get; set; }

    public string? LiquidItemCode { get; set; }

    public string? LiquidUom { get; set; }

    public double? LiquidQty { get; set; }

    public virtual CfsMain? CfsMain { get; set; }
}
