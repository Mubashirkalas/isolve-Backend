using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingVoucher
{
    public int? VNo { get; set; }

    public string? VType { get; set; }

    public DateOnly? VDate { get; set; }

    public string? AccountCode { get; set; }

    public string? Narration { get; set; }

    public string ChequeNo { get; set; } = null!;

    public DateOnly ChequeDate { get; set; }

    public string? Debit { get; set; }

    public string? Credit { get; set; }

    public string? SubsegmentName { get; set; }

    public short? SubSegmentId { get; set; }

    public string? VGlyear { get; set; }

    public byte? CompId { get; set; }

    public string? BankName { get; set; }

    public int SNo { get; set; }

    public string VKey { get; set; } = null!;

    public string? Status { get; set; }
}
