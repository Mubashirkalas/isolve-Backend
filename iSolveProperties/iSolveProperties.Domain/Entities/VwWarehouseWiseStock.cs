using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwWarehouseWiseStock
{
    public string? GroupCode { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? Uom { get; set; }

    public short? SubSegmentIdMain { get; set; }

    public short? WarehouseNo { get; set; }

    public double? Qty { get; set; }

    public string? Whname { get; set; }

    public string? ItemName { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
