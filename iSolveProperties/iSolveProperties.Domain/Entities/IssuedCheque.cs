using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class IssuedCheque
{
    public string? ChequeNo { get; set; }

    public string? AccountNumber { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }
}
