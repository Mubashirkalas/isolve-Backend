using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempDepartment
{
    public byte? DepartmentId { get; set; }

    public string? DepartmentName { get; set; }

    public short? UserId { get; set; }
}
