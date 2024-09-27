using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CylinderRegistration
{
    public string Srno { get; set; } = null!;

    public string? CylinderNo { get; set; }

    public string? Ownership { get; set; }

    public DateOnly? Date { get; set; }

    public string? Capacity { get; set; }

    public string? FillingCapacity { get; set; }

    public string? Gasfilledin { get; set; }

    public DateOnly? Pdate { get; set; }

    public string? Pfrom { get; set; }

    public string? Manufacturer { get; set; }

    public double? Pprice { get; set; }

    public string? TestPressure { get; set; }

    public string? TestSchedule { get; set; }

    public double? Weight { get; set; }

    public string? Color { get; set; }

    public string? WorkingPressure { get; set; }

    public int? Security { get; set; }

    public bool? Status { get; set; }

    public int CompId { get; set; }

    public string? ValveSize { get; set; }

    public string? ActualVolume { get; set; }

    public string? VolumePunched { get; set; }

    public string? ValveType { get; set; }

    public DateOnly? Manufacturing { get; set; }
}
