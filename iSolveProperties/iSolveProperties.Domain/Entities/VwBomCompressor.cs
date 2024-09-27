using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBomCompressor
{
    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public double? CompressorConversionCost { get; set; }

    public string? CUom { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? CompressorGroupCode { get; set; }

    public string? CompressorItemCode { get; set; }

    public string? CompressorUom { get; set; }

    public double? CompressorQty { get; set; }

    public string? ItemName { get; set; }

    public string? Itemname1 { get; set; }
}
