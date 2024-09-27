using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLoanAndAdvanceDeductionSetupDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public int? Sno { get; set; }

    public string? AdjustmentParameterCode { get; set; }

    public string? AdjustmentRule { get; set; }

    public string? AdjustmentParameter { get; set; }
}
