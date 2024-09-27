using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalePurchaseRate
{
    public double? Rate { get; set; }

    public double? RetailRate { get; set; }

    public double? WholeSalesRate { get; set; }

    public double? SupplierRate { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public byte? CompId { get; set; }
}
