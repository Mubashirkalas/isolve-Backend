using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwWodetail
{
    public string? TrWo { get; set; }

    public string? WoDesc { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Grnno { get; set; }

    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public decimal TrQty { get; set; }

    public decimal TrValue { get; set; }
}
