using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Segment
{
    public short SegmentId { get; set; }

    public string? SegmentName { get; set; }

    public double? Amount { get; set; }

    public byte CompId { get; set; }
}
