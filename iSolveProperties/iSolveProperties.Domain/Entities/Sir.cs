using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Sir
{
    public string? TrCc { get; set; }

    public string? TrMch { get; set; }

    public string? TrItemno { get; set; }

    public decimal? TrQty { get; set; }

    public decimal? TrValue { get; set; }

    public string? ItDesc { get; set; }

    public string? CcDesc { get; set; }

    public string? MchDesc { get; set; }

    public int Grnno { get; set; }

    public DateTime? Grndate { get; set; }

    public string? TrType { get; set; }

    public string? Type { get; set; }
}
