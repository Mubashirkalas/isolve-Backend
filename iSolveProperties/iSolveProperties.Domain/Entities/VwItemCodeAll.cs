using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemCodeAll
{
    public string ItCode { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? ItLoc { get; set; }

    public string? ItPartno { get; set; }
}
