using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingPonew
{
    public int? PoNo { get; set; }

    public string? PoDate { get; set; }

    public string? Bpcode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public bool? Import { get; set; }

    public short SubSegmentIdpomaster { get; set; }

    public bool? Approved { get; set; }

    public string Keys { get; set; } = null!;

    public string? Status { get; set; }

    public string? SrNo { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
