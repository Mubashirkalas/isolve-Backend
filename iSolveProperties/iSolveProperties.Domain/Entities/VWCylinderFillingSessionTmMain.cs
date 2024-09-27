using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWCylinderFillingSessionTmMain
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? CfsessionTmNo { get; set; }

    public DateOnly? CfsessionTmDate { get; set; }

    public string? Platform { get; set; }

    public string? Product { get; set; }

    public string? Shift { get; set; }

    public string? Fillerman { get; set; }

    public string? Name { get; set; }

    public string? Purity { get; set; }

    public string? Checkedby { get; set; }
}
