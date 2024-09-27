using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalaryDispersementSetup
{
    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public int? Sno { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? PaymentMode { get; set; }
}
