using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGrnapproval
{
    public int? Grnno { get; set; }

    public short SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public int? Srno { get; set; }

    public string? Type { get; set; }

    public string? Date { get; set; }

    public string? BpCode { get; set; }

    public string? Status { get; set; }

    public string? BusinessPartnersName { get; set; }

    public DateOnly? Grndate { get; set; }

    public bool? Approved { get; set; }

    public string Keys { get; set; } = null!;
}
