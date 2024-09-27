using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwledger
{
    public DateOnly? Gdate { get; set; }

    public string? Itdesc { get; set; }

    public double? Grnno { get; set; }

    public string? Ccdesc { get; set; }

    public string? TrItemno { get; set; }

    public string? Itunit { get; set; }

    public decimal? Qty { get; set; }

    public string? Type { get; set; }
}
