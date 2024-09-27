using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWEcrMain
{
    public string Keys { get; set; } = null!;

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public int? EcrNo { get; set; }

    public DateOnly? EcrDate { get; set; }

    public string? VehicleId { get; set; }

    public double? IgpNo { get; set; }

    public DateOnly? IgpDate { get; set; }

    public string? RouteReturn { get; set; }

    public string? SubSegmentName { get; set; }
}
