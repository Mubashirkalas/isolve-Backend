using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMinRateHistory
{
    public string? TrGrnnoMinn { get; set; }

    public string ItCode { get; set; } = null!;

    public string? ItUnit { get; set; }

    public string? ItDesc { get; set; }

    public decimal? Minrate { get; set; }

    public string? PartyMin { get; set; }

    public DateOnly? GrndateMinn { get; set; }
}
