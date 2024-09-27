using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPreviousTankStatus
{
    public double? Chartkg { get; set; }

    public double? Chartm3 { get; set; }

    public DateOnly? DecantingDate { get; set; }

    public string? TankNo { get; set; }

    public string? GasStored { get; set; }
}
