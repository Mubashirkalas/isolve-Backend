using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwoptran
{
    public string Opdate { get; set; } = null!;

    public string? TrItemno { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Value { get; set; }
}
