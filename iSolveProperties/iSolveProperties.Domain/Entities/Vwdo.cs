using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwdo
{
    public string? DoNo { get; set; }

    public string Keyfield { get; set; } = null!;

    public DateTime? DoDate { get; set; }

    public string? DoVehicle { get; set; }

    public string? DoDelby { get; set; }

    public int CompId { get; set; }

    public string DoType { get; set; } = null!;

    public int DoSrno { get; set; }

    public string? DoGrnno { get; set; }

    public string? DoBill { get; set; }

    public string? DoParty { get; set; }

    public double? DoValue { get; set; }

    public double? DoQty { get; set; }

    public string? DoUnit { get; set; }

    public string? DoItdesc { get; set; }

    public string? DoItem { get; set; }

    public string? DoPi { get; set; }

    public string? DoPo { get; set; }

    public string? DoRemarks { get; set; }

    public string GlYear { get; set; } = null!;

    public string? Grnno { get; set; }
}
