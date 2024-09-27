using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemBom
{
    public byte? Sno { get; set; }

    public string? GroupCodeRaw { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCodeRaw { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Amount { get; set; }

    public byte? CompId { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemGroup { get; set; }
}
