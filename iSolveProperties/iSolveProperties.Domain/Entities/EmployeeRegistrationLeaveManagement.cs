using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeRegistrationLeaveManagement
{
    public byte? CompId { get; set; }

    public int? SrNo { get; set; }

    public short? SNo { get; set; }

    public string? LeaveType { get; set; }

    public string? StandardLeave { get; set; }

    public string? AllowedLeave { get; set; }

    public bool? LeaveEncashment { get; set; }

    public virtual EmployeeRegistrationMain? EmployeeRegistrationMain { get; set; }
}
