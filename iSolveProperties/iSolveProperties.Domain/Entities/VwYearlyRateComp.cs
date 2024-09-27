using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwYearlyRateComp
{
    public string? Year { get; set; }

    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public decimal? MRate { get; set; }
}
