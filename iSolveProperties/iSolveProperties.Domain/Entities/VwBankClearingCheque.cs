using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankClearingCheque
{
    public string? Srno { get; set; }

    public short? Sno { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public string? ChequeSlipno { get; set; }

    public DateOnly? Date { get; set; }

    public double? Amount { get; set; }

    public string? Remarks { get; set; }
}
