using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemwarehouse
{
    public short? Whno { get; set; }

    public string? Whname { get; set; }

    public string? Whlocation { get; set; }

    public string? Whaddress { get; set; }

    public string? SubSegmentName { get; set; }

    public string? ItemGroup { get; set; }

    public byte? CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public string? ItemCode { get; set; }

    public short? Expr1 { get; set; }

    public double? MinQty { get; set; }

    public double? ReOrderQty { get; set; }

    public double? MaxQty { get; set; }

    public string? ItemName { get; set; }

    public string? GroupCode { get; set; }

    public double? CriticalQty { get; set; }
}
