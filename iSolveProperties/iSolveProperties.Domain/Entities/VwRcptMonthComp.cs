using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRcptMonthComp
{
    public string? Main { get; set; }

    public int? Cdate { get; set; }

    public decimal? Value { get; set; }

    public string? ItDesc { get; set; }
}
