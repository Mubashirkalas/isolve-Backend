using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankPosition
{
    public string? Type { get; set; }

    public DateOnly? VDate { get; set; }

    public int? VNo { get; set; }

    public string? AccountNo { get; set; }

    public string? AccountTitle { get; set; }

    public byte BankId { get; set; }

    public string? BankName { get; set; }

    public string? CheqNo { get; set; }

    public DateOnly? CheqDate { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public byte? CompId { get; set; }

    public string? VGlyear { get; set; }

    public byte? SubSegmentId { get; set; }

    public byte? SegmentId { get; set; }

    public string? SegmentName { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
