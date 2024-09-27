using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalesGroup
{
    public string? Srno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Value { get; set; }

    public DateOnly? SalesDate { get; set; }

    public byte CompId { get; set; }
}
