using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class WarehouseSubSegment
{
    public byte? SubSegmentId { get; set; }

    public short? Whno { get; set; }

    public byte? CompId { get; set; }

    public byte? Listindex { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
