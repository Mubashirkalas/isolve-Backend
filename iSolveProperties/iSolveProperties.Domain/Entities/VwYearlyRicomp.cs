using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwYearlyRicomp
{
    public string? Year { get; set; }

    public decimal Receipts { get; set; }

    public decimal Issues { get; set; }
}
