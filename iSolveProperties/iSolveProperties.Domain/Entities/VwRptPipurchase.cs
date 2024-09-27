using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRptPipurchase
{
    public DateOnly? Grndate { get; set; }

    public decimal? TrAccept { get; set; }

    public int? CompId { get; set; }

    public string? TrItemno { get; set; }

    public string? Year { get; set; }
}
