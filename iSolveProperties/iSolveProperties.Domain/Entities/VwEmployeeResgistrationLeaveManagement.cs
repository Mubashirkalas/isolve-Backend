using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeResgistrationLeaveManagement
{
    public short? SNo { get; set; }

    public string? LeaveType { get; set; }

    public string? StandardLeave { get; set; }

    public string? AllowedLeave { get; set; }

    public bool? LeaveEncashment { get; set; }

    public byte? CompId { get; set; }

    public string? SrNo { get; set; }
}
