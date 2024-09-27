using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwinventory
{
    public string ItCode { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public double? Quantity { get; set; }

    public double? Value { get; set; }
}
