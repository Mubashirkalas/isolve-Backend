using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class RegionRight
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? UserId { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public virtual SubSegment? SubSegment { get; set; }

    public virtual User? User { get; set; }
}
