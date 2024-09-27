using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CfstmMain
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public int? CsfNo { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public double? CompressorConversionCost { get; set; }

    public string? CUom { get; set; }

    public double? LiquidConversionCost { get; set; }

    public string? LUom { get; set; }
}
