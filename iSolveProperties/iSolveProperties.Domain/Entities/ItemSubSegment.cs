using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ItemSubSegment
{
    public short? SubSegmentId { get; set; }

    public string? ItemCode { get; set; }

    public byte? CompId { get; set; }

    public byte? Listindex { get; set; }

    public string? ItemGroup { get; set; }

    public virtual ItemMaster? ItemMaster { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
