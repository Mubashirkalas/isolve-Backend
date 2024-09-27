using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankClearingDetail1
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short? Sno { get; set; }

    public int? Vno { get; set; }

    public DateOnly? Date { get; set; }

    public string? AccountNo { get; set; }

    public string? BankName { get; set; }

    public string? ChequeNo { get; set; }

    public string? Narration { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public string? Action { get; set; }

    public string? VKey { get; set; }
}
