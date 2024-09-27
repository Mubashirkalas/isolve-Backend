using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeAttendanceDetailZkt
{
    public string? EmployeeName { get; set; }

    public DateTime? AttendanceDate { get; set; }

    public DateTime? Checkout { get; set; }

    public DateTime? Checkin { get; set; }

    public int? Zkid { get; set; }

    public short? SubSegmentId { get; set; }

    public string? DepartmentCode { get; set; }

    public string EmployeeSrno { get; set; } = null!;

    public string? DesignationCode { get; set; }

    public string? SubSegmentName { get; set; }

    public byte CompId { get; set; }

    public string? DesignationTitle { get; set; }

    public string? DepartmentName { get; set; }
}
