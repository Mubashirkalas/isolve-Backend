using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAtcCylinderReconciliationNew
{
    public string? Product { get; set; }

    public string? Ownership { get; set; }

    public string? Capacity { get; set; }

    public int? CylinderQty { get; set; }

    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }
}
