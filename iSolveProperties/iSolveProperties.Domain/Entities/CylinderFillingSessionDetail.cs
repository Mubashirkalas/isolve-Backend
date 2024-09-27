using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CylinderFillingSessionDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public int? CfsessionNo { get; set; }

    public int? Sno { get; set; }

    public string? Batch { get; set; }

    public string? Temp { get; set; }

    public string? Pressure { get; set; }

    public string? StartTime { get; set; }

    public string? EndTime { get; set; }

    public double? Cap990 { get; set; }

    public double? Cap790 { get; set; }

    public double? Cap680 { get; set; }

    public double? Cap590 { get; set; }

    public double? Cap500 { get; set; }

    public double? Cap340 { get; set; }

    public double? Cap170 { get; set; }

    public double? Cap085 { get; set; }

    public double? Total { get; set; }

    public virtual CylinderFillingSessionMain? CylinderFillingSessionMain { get; set; }
}
