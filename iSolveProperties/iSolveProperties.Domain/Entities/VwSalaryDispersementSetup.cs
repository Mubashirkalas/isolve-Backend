using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalaryDispersementSetup
{
    public string SubSegmentName { get; set; } = null!;

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public int? Sno { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? PaymentMode { get; set; }
}
