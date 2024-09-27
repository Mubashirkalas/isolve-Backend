using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalesWithCg
{
    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public int? Qty { get; set; }

    public double? Value { get; set; }

    public int ReturnQty { get; set; }

    public double ReturnValue { get; set; }

    public DateOnly? SalesDate { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemName { get; set; }

    public double? Rate { get; set; }

    public double? Prate { get; set; }
}
