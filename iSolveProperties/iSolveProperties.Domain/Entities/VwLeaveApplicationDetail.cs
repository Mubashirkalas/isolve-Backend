using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLeaveApplicationDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? LeaveTypeCode { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public int? TotalLeaves { get; set; }

    public int? AvailedLeaves { get; set; }

    public int? RemainingLeaves { get; set; }

    public int? AppliedLeaves { get; set; }

    public int? ApprovedLeaves { get; set; }

    public int? BalanceLeaves { get; set; }

    public string? LeaveType { get; set; }
}
