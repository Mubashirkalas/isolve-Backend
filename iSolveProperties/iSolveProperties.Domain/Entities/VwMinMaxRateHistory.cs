using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMinMaxRateHistory
{
    public string ItCode { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? TrGrnnomaxx { get; set; }

    public decimal? Maxrateact { get; set; }

    public string? Partymax { get; set; }

    public DateOnly? Grndatemax { get; set; }

    public string? TrGrnnominn { get; set; }

    public decimal? Minrateact { get; set; }

    public string? Partymin { get; set; }

    public DateOnly? Grndateminn { get; set; }
}
