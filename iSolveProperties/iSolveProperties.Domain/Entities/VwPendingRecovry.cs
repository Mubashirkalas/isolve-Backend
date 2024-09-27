using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingRecovry
{
    public string BpCode { get; set; } = null!;

    public double? RemainingAmount { get; set; }

    public string IpNo { get; set; } = null!;

    public DateOnly? IpDate { get; set; }

    public string? BpName { get; set; }

    public string? Status { get; set; }
}
