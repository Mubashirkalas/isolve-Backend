using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ItemWarehouse
{
    public short? Whno { get; set; }

    public string? ItemCode { get; set; }

    public byte? CompId { get; set; }

    public string? ItemGroup { get; set; }

    public short? SubSegmentId { get; set; }

    public double? MinQty { get; set; }

    public double? MaxQty { get; set; }

    public double? ReOrderQty { get; set; }

    public double? CriticalQty { get; set; }

    public virtual ItemMaster? ItemMaster { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
