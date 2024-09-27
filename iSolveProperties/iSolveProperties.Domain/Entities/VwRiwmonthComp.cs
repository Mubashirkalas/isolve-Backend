using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRiwmonthComp
{
    public int? MMonth { get; set; }

    public decimal Receipts { get; set; }

    public decimal Issues { get; set; }
}
