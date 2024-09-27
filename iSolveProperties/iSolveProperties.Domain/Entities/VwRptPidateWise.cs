using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRptPidateWise
{
    public string PiNo { get; set; } = null!;

    public string? PiItemno { get; set; }

    public string? ItDesc { get; set; }

    public int CompId { get; set; }

    public string? Year { get; set; }

    public DateTime? PiDate { get; set; }

    public decimal? PiQtY { get; set; }
}
