using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LoanAndAdvancesDeductionSetup
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public DateOnly? ApplicableDate { get; set; }
}
