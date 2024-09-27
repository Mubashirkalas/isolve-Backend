using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwmaxratehistoryact
{
    public string? ItDesc { get; set; }

    public string ItCode { get; set; } = null!;

    public string? ItUnit { get; set; }

    public string? TrGrnnomaxx { get; set; }

    public decimal? Maxrateact { get; set; }

    public string? Partymax { get; set; }

    public DateOnly? Grndatemax { get; set; }
}
