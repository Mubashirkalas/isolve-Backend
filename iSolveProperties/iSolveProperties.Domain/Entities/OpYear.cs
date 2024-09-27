using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class OpYear
{
    public DateTime? StDate { get; set; }

    public DateTime? EndDate { get; set; }

    public string Year { get; set; } = null!;

    public string? CurrentYear { get; set; }
}
