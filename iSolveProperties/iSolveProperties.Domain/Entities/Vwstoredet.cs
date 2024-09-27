using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwstoredet
{
    public string? TrCc { get; set; }

    public string? CcDesc { get; set; }

    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Value { get; set; }
}
