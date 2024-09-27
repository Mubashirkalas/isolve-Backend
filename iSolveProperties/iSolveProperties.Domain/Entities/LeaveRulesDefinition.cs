using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LeaveRulesDefinition
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Title { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public int? TotalLeaves { get; set; }

    public int? MinimumLeaves { get; set; }

    public int? IntimationBeforeLeave { get; set; }
}
