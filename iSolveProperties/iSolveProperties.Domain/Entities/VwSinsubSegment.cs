using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSinsubSegment
{
    public string? Grnno { get; set; }

    public byte SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Srno { get; set; }

    public string? Type { get; set; }

    public string? Date { get; set; }

    public string? Status { get; set; }
}
