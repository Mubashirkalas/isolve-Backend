using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemRateHist
{
    public string? TrItemno { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Grnno { get; set; }

    public string? Party { get; set; }

    public string? PrtyName { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public decimal TrAccept { get; set; }

    public decimal TrValue { get; set; }

    public decimal? Rate { get; set; }

    public string? Abbr { get; set; }
}
