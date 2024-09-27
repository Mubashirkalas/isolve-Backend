using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwStoreSecConsSum
{
    public string? Item { get; set; }

    public decimal? Value { get; set; }

    public string? ItDesc { get; set; }

    public decimal TrQty { get; set; }
}
