using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeOfMonth
{
    public string SerialNo { get; set; } = null!;

    public int CompId { get; set; }

    public string? EmployeeSrno { get; set; }

    public string? Month { get; set; }

    public byte[]? Pic { get; set; }

    public string? ImagePath { get; set; }
}
