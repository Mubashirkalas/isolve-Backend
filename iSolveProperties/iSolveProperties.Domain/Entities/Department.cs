using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Department
{
    public int DId { get; set; }

    public string DName { get; set; } = null!;
}
