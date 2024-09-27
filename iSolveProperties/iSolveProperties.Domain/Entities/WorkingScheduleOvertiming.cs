using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class WorkingScheduleOvertiming
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public byte? Sno { get; set; }

    public short? SubSegmentId { get; set; }

    public string? RulesLevel { get; set; }

    public string? AtEmployee { get; set; }

    public string? AtScale { get; set; }

    public string? AtDesignation { get; set; }

    public double? Percentage { get; set; }

    public string? Per { get; set; }

    public string? Days { get; set; }

    public virtual WorkingScheduleMain? WorkingScheduleMain { get; set; }
}
