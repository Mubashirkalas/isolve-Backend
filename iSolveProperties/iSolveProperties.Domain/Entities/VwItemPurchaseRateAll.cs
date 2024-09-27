using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemPurchaseRateAll
{
    public string? Item { get; set; }

    public string? MaxGrn { get; set; }

    public DateOnly? Grndate { get; set; }

    public decimal? Rate { get; set; }

    public string? Party { get; set; }

    public string? PrtyName { get; set; }

    public decimal? ItCbal { get; set; }

    public decimal? TrAccept { get; set; }

    public string? Abbr { get; set; }
}
