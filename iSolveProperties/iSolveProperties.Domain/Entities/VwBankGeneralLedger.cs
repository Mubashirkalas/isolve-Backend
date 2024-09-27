using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankGeneralLedger
{
    public double ObbankVdetail { get; set; }

    public int? Coaob { get; set; }

    public string? AccountNumber { get; set; }

    public string? VType { get; set; }

    public int? SNo { get; set; }

    public DateOnly? VDate { get; set; }

    public int? VNo { get; set; }

    public string? CheqNo { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public DateOnly? CheqDate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? VGlyear { get; set; }

    public bool? VPost { get; set; }
}
