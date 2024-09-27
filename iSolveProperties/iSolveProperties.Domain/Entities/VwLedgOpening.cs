using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLedgOpening
{
    public string ItCode { get; set; } = null!;

    public decimal Qty { get; set; }

    public decimal? Opening { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? Opdate { get; set; }
}
