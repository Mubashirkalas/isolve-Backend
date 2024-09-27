using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Adil
{
    public string? TrItemno { get; set; }

    public decimal? TrQty { get; set; }

    public decimal? TrValue { get; set; }

    public decimal? TrStax { get; set; }

    public string GlDesc { get; set; } = null!;

    public DateTime? Grndate { get; set; }

    public string? Party { get; set; }

    public string? ItDesc { get; set; }

    public string? TrPretGrnno { get; set; }
}
