using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwopening
{
    public string ItCode { get; set; } = null!;

    public decimal? Opening { get; set; }

    public decimal? Opvalue { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? ItPartno { get; set; }

    public string? Opdate { get; set; }

    public string? ItLoc { get; set; }

    public bool? ItImp { get; set; }

    public int CompId { get; set; }
}
