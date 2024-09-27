using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DoDetail
{
    public string Keyfield { get; set; } = null!;

    public int CompId { get; set; }

    public string? DoPo { get; set; }

    public string? DoPi { get; set; }

    public string? DoItem { get; set; }

    public string? DoItdesc { get; set; }

    public string? DoUnit { get; set; }

    public double? DoQty { get; set; }

    public double? DoValue { get; set; }

    public string? DoParty { get; set; }

    public string? DoBill { get; set; }

    public string? DoGrnno { get; set; }

    public int DoSrno { get; set; }

    public string DoType { get; set; } = null!;

    public string GlYear { get; set; } = null!;
}
