using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLoanAndAdvanceDeductionMainDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public DateOnly? ApplicableDate { get; set; }

    public int? Sno { get; set; }

    public string? AdjustmentParameterCode { get; set; }

    public string? AdjustmentRule { get; set; }

    public byte? SubSegmentId { get; set; }
}
