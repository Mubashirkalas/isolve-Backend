using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAccumulatedBalance
{
    public string GlCode { get; set; } = null!;

    public string GlDesc { get; set; } = null!;

    public double Bal { get; set; }

    public double Movement { get; set; }
}
