using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPlupto
{
    public string? GlPlcode { get; set; }

    public string GlCode { get; set; } = null!;

    public double? Amount { get; set; }
}
