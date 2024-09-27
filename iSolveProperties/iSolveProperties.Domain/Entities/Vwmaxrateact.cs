using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwmaxrateact
{
    public string Itemcode { get; set; } = null!;

    public decimal? MaxrateAct { get; set; }

    public string? TrGrnnomaxxact { get; set; }
}
