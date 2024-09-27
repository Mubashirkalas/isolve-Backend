using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwIpsubSegment
{
    public string IpNo { get; set; } = null!;

    public string? Date { get; set; }

    public byte SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string BpCode { get; set; } = null!;

    public string? Status { get; set; }

    public string? DispatchInvoices { get; set; }
}
