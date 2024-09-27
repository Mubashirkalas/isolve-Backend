using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwslowmovingitem
{
    public string ItCode { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string? ItPartno { get; set; }

    public string? ItUnit { get; set; }

    public decimal? ItCbal { get; set; }

    public decimal? ItAvgval { get; set; }

    public decimal? ItCRate { get; set; }
}
