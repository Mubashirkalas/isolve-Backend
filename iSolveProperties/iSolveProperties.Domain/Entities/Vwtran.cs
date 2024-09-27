using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwtran
{
    public DateOnly? Grndate { get; set; }

    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public double? Grnno { get; set; }

    public string? CcDesc { get; set; }

    public string? ItPartno { get; set; }

    public string? ItUnit { get; set; }

    public decimal? Qty { get; set; }

    public string? Type { get; set; }

    public bool? ItImp { get; set; }
}
