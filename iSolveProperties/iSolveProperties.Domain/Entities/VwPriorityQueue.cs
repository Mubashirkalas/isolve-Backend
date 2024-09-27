using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPriorityQueue
{
    public short SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public short? Sno { get; set; }

    public short? EmployeeId { get; set; }

    public short? Turns { get; set; }

    public short UserId { get; set; }

    public string? UserName { get; set; }

    public byte CompId { get; set; }

    public string? EmployeeName { get; set; }

    public string? TeamName { get; set; }
}
