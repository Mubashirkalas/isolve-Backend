using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CfsCompressor
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public int? CsfNo { get; set; }

    public short? Sno { get; set; }

    public string? CompressorGroupCode { get; set; }

    public string? CompressorItemCode { get; set; }

    public string? CompressorUom { get; set; }

    public double? CompressorQty { get; set; }

    public virtual CfsMain? CfsMain { get; set; }
}
