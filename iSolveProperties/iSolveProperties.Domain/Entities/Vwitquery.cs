using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwitquery
{
    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? ItPartno { get; set; }

    public decimal ItRoqty { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Value { get; set; }
}
