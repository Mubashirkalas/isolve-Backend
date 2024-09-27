using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeAttendanceDetail
{
    public string? EmployeeName { get; set; }

    public string? DepartmentName { get; set; }

    public string? DesignationTitle { get; set; }

    public string? ReaderId { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? EmployeeSrno { get; set; }

    public byte? CompId { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DesignationCode { get; set; }

    public DateTime? CheckTime { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
