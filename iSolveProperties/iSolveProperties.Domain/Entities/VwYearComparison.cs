using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwYearComparison
{
    public string? TrCc { get; set; }

    public string? TrItemno { get; set; }

    public string? Keyfield { get; set; }

    public string? Type { get; set; }

    public decimal TrValue { get; set; }

    public decimal? TrAccept { get; set; }

    public string? TrConstyp { get; set; }

    public string? TrFoc { get; set; }

    public string? Year { get; set; }
}
