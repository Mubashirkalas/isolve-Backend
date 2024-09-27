using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalesValue
{
    public decimal? TotalValue { get; set; }

    public DateOnly? GrnDate { get; set; }

    public double? SalesValue { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public byte CompId { get; set; }
}
