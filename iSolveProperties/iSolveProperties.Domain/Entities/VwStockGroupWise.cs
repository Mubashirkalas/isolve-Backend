using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwStockGroupWise
{
    public string ItCode { get; set; } = null!;

    public string? ItDesc { get; set; }

    public decimal? PurchaseValue { get; set; }

    public double? SalesValue { get; set; }
}
