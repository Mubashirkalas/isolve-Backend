using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwWorkingScheduleWorkTiming
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public int? Sno { get; set; }

    public short? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? RulesLevel { get; set; }

    public string? AtEmployee { get; set; }

    public string? AtScale { get; set; }

    public string? AtDesignation { get; set; }

    public string? Days { get; set; }

    public DateTime? StartTiming { get; set; }

    public DateTime? EndTiming { get; set; }

    public string? EmployeeName { get; set; }

    public string? DesignationTitle { get; set; }
}
