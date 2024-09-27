using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemMonthConsComp
{
    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public int? Moth { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Value { get; set; }
}
