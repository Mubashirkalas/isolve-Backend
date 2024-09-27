using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalesgroupwise
{
    public string ItCode { get; set; } = null!;

    public string? ItDesc { get; set; }

    public double? Qty { get; set; }
}
