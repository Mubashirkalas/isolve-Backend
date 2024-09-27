using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FormState
{
    public string? ChildName { get; set; }

    public string? State { get; set; }

    public int? Users { get; set; }
}
