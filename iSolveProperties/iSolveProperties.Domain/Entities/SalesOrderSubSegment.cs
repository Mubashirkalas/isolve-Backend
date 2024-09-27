using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalesOrderSubSegment
{
    public short? SubSegmentId { get; set; }

    public int? SrNo { get; set; }

    public byte? CompId { get; set; }

    public byte? Listindex { get; set; }

    public string? FYear { get; set; }
}
