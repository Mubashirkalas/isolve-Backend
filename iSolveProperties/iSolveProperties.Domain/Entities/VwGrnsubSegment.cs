using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGrnsubSegment
{
    public string? Grnno { get; set; }

    public short SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Srno { get; set; }

    public string? Type { get; set; }

    public string? Date { get; set; }

    public string? BpCode { get; set; }

    public string? Status { get; set; }

    public bool? Approved { get; set; }
}
