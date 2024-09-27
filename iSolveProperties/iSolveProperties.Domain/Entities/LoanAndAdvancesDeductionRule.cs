using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LoanAndAdvancesDeductionRule
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? RuleLevel { get; set; }

    public string? LatypeCode { get; set; }
}
