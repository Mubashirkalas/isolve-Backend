using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSaleOrderComparison
{
    public DateOnly? SaleDate { get; set; }

    public string? BpCode { get; set; }

    public double? UnitRate { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? SaleNo { get; set; }
}
