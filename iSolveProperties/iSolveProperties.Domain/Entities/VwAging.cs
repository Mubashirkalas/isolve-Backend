using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAging
{
    public string VKey { get; set; } = null!;

    public int SNo { get; set; }

    public string? VType { get; set; }

    public DateOnly? VDate { get; set; }

    public int? VNo { get; set; }

    public string? BpCode { get; set; }

    public string? CheqNo { get; set; }

    public DateOnly? CheqDate { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public byte? CompId { get; set; }

    public string? VGlyear { get; set; }

    public byte? SubSegmentId { get; set; }

    public byte? SegmentId { get; set; }

    public string? Status { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public string BusinessPartnersCode { get; set; } = null!;
}
