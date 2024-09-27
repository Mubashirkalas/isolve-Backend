using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CylinderFillingSessionTmDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? CfsessionTmNo { get; set; }

    public short? Sno { get; set; }

    public string? CylinderNo { get; set; }

    public double? TareWeight { get; set; }

    public double? EmptyWeight { get; set; }

    public double? AcetoneFilledKg { get; set; }

    public double? CylinderWeightWithacetone { get; set; }

    public double? WeightAfterFilling { get; set; }

    public double? GasFilledKg { get; set; }

    public virtual CylinderFillingSessionTmMain? CylinderFillingSessionTmMain { get; set; }
}
