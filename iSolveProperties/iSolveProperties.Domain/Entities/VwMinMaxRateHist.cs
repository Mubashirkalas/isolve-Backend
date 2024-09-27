using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMinMaxRateHist
{
    public string TrItemno { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? Mingrnno { get; set; }

    public DateOnly? Mingrndate { get; set; }

    public string? Minpname { get; set; }

    public decimal? Minrate { get; set; }

    public string? Maxgrnno { get; set; }

    public DateOnly? Maxgrndate { get; set; }

    public string? Maxpname { get; set; }

    public decimal? Maxrate { get; set; }
}
