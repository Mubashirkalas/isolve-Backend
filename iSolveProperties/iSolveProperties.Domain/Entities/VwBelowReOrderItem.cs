using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBelowReOrderItem
{
    public string? BpCode { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? ReOrder { get; set; }

    public double RemainingQty { get; set; }

    public string? ItDesc { get; set; }

    public byte? CompId { get; set; }

    public double? Rate { get; set; }
}
