using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Tank
{
    public string TankNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public double? CommercialValue { get; set; }

    public string? TankModelno { get; set; }

    public string? Property { get; set; }

    public string? GasStored { get; set; }

    public double? FromLevelrang { get; set; }

    public double? ToLevelrang { get; set; }

    public double? CapacityKg { get; set; }

    public double? CapacityM3 { get; set; }

    public double? CapacityLtr { get; set; }

    public string? MaximumWp { get; set; }

    public string? Location { get; set; }

    public double? StandardWeight { get; set; }

    public string? SiteLocation { get; set; }

    public virtual ICollection<TankChart> TankCharts { get; set; } = new List<TankChart>();
}
