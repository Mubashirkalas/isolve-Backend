using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwYearlyRateCompDetail
{
    public string Year { get; set; } = null!;

    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public string Grnno { get; set; } = null!;

    public DateOnly? Grndate { get; set; }

    public string? PrtyName { get; set; }

    public decimal? TrValue { get; set; }

    public decimal? TrAccept { get; set; }

    public decimal? MRate { get; set; }
}
