using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwJobOrderSubSegment
{
    public string? JobOrderNo { get; set; }

    public string? JobOrderDate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Status { get; set; }

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Type { get; set; }
}
