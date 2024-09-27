using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGeneralLedgerSubSegmentWise
{
    public double ObvDetail { get; set; }

    public double Coaob { get; set; }

    public string GlCode { get; set; } = null!;

    public string? VType { get; set; }

    public int? SNo { get; set; }

    public DateOnly? VDate { get; set; }

    public int? VNo { get; set; }

    public string? CheqNo { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public string? GlDesc { get; set; }

    public DateOnly? CheqDate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? VGlyear { get; set; }

    public bool? VPost { get; set; }
}
