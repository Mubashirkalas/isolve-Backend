using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWProfitLoss
{
    public string? GlPlcode { get; set; }

    public string? GlCode { get; set; }

    public double? Amount { get; set; }

    public int Line { get; set; }

    public string Heading { get; set; } = null!;

    public int Note { get; set; }

    public int Main { get; set; }

    public string Printfigure { get; set; } = null!;

    public string Plcode { get; set; } = null!;

    public string Upline { get; set; } = null!;

    public string Box { get; set; } = null!;

    public string Downline { get; set; } = null!;

    public string Headingbold { get; set; } = null!;

    public string Figurebold { get; set; } = null!;

    public string Doubleunderline { get; set; } = null!;

    public string? GlYear { get; set; }

    public int? ProjectId { get; set; }
}
