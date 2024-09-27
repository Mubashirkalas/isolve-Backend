using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAtcCylinderReconciliation
{
    public string? CylinderNo { get; set; }

    public string? Ownership { get; set; }

    public string? Capacity { get; set; }

    public string? Gasfilledin { get; set; }

    public string Keys { get; set; } = null!;

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public int? Srno { get; set; }
}
