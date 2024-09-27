using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEmployeeBalance
{
    public string EmployeeId { get; set; } = null!;

    public string? EmployeeName { get; set; }

    public string? SubSegmentName { get; set; }

    public double? Dr { get; set; }

    public double? Cr { get; set; }

    public double? Tdr { get; set; }

    public double? Tcr { get; set; }

    public double? Opdr { get; set; }

    public double? Opcr { get; set; }
}
