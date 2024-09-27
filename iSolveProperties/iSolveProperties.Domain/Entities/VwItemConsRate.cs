using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemConsRate
{
    public string? ItemCons { get; set; }

    public string? MaxGrncons { get; set; }

    public DateOnly? GrndateLastCons { get; set; }

    public decimal? Trrate { get; set; }
}
