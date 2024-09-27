using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRecoveryAlert
{
    public DateOnly? IpDate { get; set; }

    public DateOnly? IpDateTwo { get; set; }

    public DateOnly? SalesDate { get; set; }

    public DateOnly? SalesDateTwo { get; set; }

    public double LimitDays { get; set; }

    public string? Status { get; set; }
}
