using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMaxRateHistory
{
    public string? TrGrnnomaxx { get; set; }

    public string? ItDesc { get; set; }

    public decimal? Maxrate { get; set; }

    public string? Partymax { get; set; }

    public DateOnly? Grndatemax { get; set; }

    public string ItCode { get; set; } = null!;

    public string? ItUnit { get; set; }
}
