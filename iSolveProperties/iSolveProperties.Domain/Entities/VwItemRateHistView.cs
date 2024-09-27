using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemRateHistView
{
    public string? Item { get; set; }

    public DateOnly? Date { get; set; }

    public string? DocNo { get; set; }

    public string? Party { get; set; }

    public decimal Quantity { get; set; }

    public decimal Value { get; set; }

    public decimal? Rate { get; set; }
}
