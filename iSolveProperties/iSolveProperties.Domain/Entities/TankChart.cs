using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TankChart
{
    public double TankLevel { get; set; }

    public string TankNo { get; set; } = null!;

    public byte CompId { get; set; }

    public double? LarL { get; set; }

    public double? LarKg { get; set; }

    public double? LoL { get; set; }

    public double? LoKg { get; set; }

    public double? LnL { get; set; }

    public double? LnKg { get; set; }

    public virtual Tank Tank { get; set; } = null!;
}
