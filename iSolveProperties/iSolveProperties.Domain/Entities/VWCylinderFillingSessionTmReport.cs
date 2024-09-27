using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWCylinderFillingSessionTmReport
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

    public short? Sno { get; set; }

    public string? CylinderNo { get; set; }

    public double? TareWeight { get; set; }

    public double? EmptyWeight { get; set; }

    public double? AcetoneFilledKg { get; set; }

    public double? CylinderWeightWithacetone { get; set; }

    public double? WeightAfterFilling { get; set; }

    public double? GasFilledKg { get; set; }

    public string? CName { get; set; }

    public string? CAbber { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public string? Url { get; set; }

    public byte[]? Pic { get; set; }

    public string? Levels { get; set; }

    public DateOnly? Vdate { get; set; }
}
