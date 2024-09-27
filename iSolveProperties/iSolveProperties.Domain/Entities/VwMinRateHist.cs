using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMinRateHist
{
    public string? TrItemno { get; set; }

    public string? Grnno { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? PrtyName { get; set; }

    public decimal? MinRate { get; set; }
}
