using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemWiseConsSum
{
    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? ItPartno { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Value { get; set; }
}
