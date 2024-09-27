using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwminrateact
{
    public string Itemcodemin { get; set; } = null!;

    public decimal? MinrateAct { get; set; }

    public string? TrGrnnominnact { get; set; }
}
