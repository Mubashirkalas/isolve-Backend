using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwstock
{
    public string? ItCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItPartno { get; set; }

    public string? ItUnit { get; set; }

    public decimal? Op { get; set; }

    public decimal? Opval { get; set; }

    public decimal? Cqty { get; set; }

    public decimal? Cvalue { get; set; }
}
