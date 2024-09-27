using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class WorkingScheduleWorkingTiming
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public int? Sno { get; set; }

    public short? SubSegmentId { get; set; }

    public string? RulesLevel { get; set; }

    public string? AtEmployee { get; set; }

    public string? AtScale { get; set; }

    public string? AtDesignation { get; set; }

    public string? Days { get; set; }

    public DateTime? StartTiming { get; set; }

    public DateTime? EndTiming { get; set; }

    public virtual WorkingScheduleMain? WorkingScheduleMain { get; set; }
}
