using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemBom2
{
    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Amount { get; set; }

    public string ItemGroup { get; set; } = null!;
}
