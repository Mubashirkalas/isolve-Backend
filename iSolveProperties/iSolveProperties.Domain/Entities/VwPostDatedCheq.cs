using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPostDatedCheq
{
    public DateOnly? VDate { get; set; }

    public string? CheqNo { get; set; }

    public DateOnly? CheqDate { get; set; }

    public string VKey { get; set; } = null!;

    public string? VType { get; set; }

    public string? GlCode { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public string GlDesc { get; set; } = null!;

    public int? VNo { get; set; }

    public double? Credit { get; set; }
}
