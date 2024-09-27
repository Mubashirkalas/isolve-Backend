using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwIgpsubSegment
{
    public string SubSegmentName { get; set; } = null!;

    public string IgpNo { get; set; } = null!;

    public string? IgpDate { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? Status { get; set; }

    public string? Srno { get; set; }
}
