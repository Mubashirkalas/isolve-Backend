using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DoMain
{
    public string? DoNo { get; set; }

    public string Keyfield { get; set; } = null!;

    public DateTime? DoDate { get; set; }

    public string? DoVehicle { get; set; }

    public string? DoDelby { get; set; }

    public int CompId { get; set; }

    public string DoType { get; set; } = null!;

    public string? DoRemarks { get; set; }

    public string GlYear { get; set; } = null!;
}
