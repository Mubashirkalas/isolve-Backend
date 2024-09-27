using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwB
{
    public string? GlBlcode { get; set; }

    public string? GlCode { get; set; }

    public double? NetAmount { get; set; }

    public double? OpNetAmount { get; set; }

    public double? DrAmount { get; set; }

    public double? CrAmount { get; set; }
}
