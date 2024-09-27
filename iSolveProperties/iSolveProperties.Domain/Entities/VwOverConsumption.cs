using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwOverConsumption
{
    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public string? ItPartno { get; set; }

    public string? ItUnit { get; set; }

    public int? Gmonth { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Value { get; set; }
}
