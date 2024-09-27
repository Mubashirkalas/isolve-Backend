using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPartyAging
{
    public string? Party { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Accept { get; set; }

    public int? No { get; set; }
}
