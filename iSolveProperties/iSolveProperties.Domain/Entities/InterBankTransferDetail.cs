using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InterBankTransferDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public short? Sno { get; set; }

    public byte? ToBankid { get; set; }

    public string? ToAcno { get; set; }

    public byte? FromBankid { get; set; }

    public string? FromAcno { get; set; }

    public string? Narration { get; set; }

    public string? ChequebookNo { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public double? Amount { get; set; }

    public virtual InterBankTransferMain InterBankTransferMain { get; set; } = null!;
}
