using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TrialBalance1
{
    public string GlCode { get; set; } = null!;

    public string GlDesc { get; set; } = null!;

    public double? Dr { get; set; }

    public double? Cr { get; set; }

    public double Chartdr { get; set; }

    public double Chartcr { get; set; }

    public double? Tdr { get; set; }

    public double? Tcr { get; set; }
}
