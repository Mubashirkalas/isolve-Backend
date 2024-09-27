using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBsnote1
{
    public string? GlBlcode { get; set; }

    public string GlCode { get; set; } = null!;

    public string GlDesc { get; set; } = null!;

    public double? NetAmount { get; set; }

    public double? DrAmount { get; set; }

    public double? CrAmount { get; set; }
}
