using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTeamMasterDetail
{
    public int SerialNo { get; set; }

    public string? TeamName { get; set; }

    public short? SubSegmentId { get; set; }

    public short? Sno { get; set; }

    public short? EmployeeId { get; set; }

    public short? Turns { get; set; }

    public short UserId { get; set; }

    public string? UserName { get; set; }

    public byte CompId { get; set; }

    public string? EmployeeName { get; set; }
}
