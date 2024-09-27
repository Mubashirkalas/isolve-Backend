using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LeaveApplicationApprovedDate
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public DateOnly? ApprovedDate { get; set; }

    public bool? IsCancelled { get; set; }

    public virtual LeaveApplication LeaveApplication { get; set; } = null!;
}
