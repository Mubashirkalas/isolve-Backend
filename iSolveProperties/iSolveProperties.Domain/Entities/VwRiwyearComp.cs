using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRiwyearComp
{
    public string Year { get; set; } = null!;

    public decimal? Receipts { get; set; }

    public decimal? Issues { get; set; }
}
