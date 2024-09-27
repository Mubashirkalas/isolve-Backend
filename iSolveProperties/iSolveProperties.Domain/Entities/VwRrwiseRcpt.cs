using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRrwiseRcpt
{
    public string? Main { get; set; }

    public string? Grnno { get; set; }

    public DateOnly? Grndate { get; set; }

    public decimal Value { get; set; }

    public decimal? TrStax { get; set; }

    public decimal? TrFr { get; set; }
}
