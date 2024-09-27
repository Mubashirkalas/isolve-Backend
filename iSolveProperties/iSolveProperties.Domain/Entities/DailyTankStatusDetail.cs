using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DailyTankStatusDetail
{
    public byte? SNo { get; set; }

    public string? TankNo { get; set; }

    public string? TankName { get; set; }

    public double? PreviousLevel { get; set; }

    public double? PreviousPressure { get; set; }

    public double? QtyPreviousKg { get; set; }

    public double? QtyPreviousM3 { get; set; }

    public double? QtyDecantedKg { get; set; }

    public double? QtyDecantedM3 { get; set; }

    public double? QtyAvailableforfillingKg { get; set; }

    public double? QtyAvailableforfillingM3 { get; set; }

    public double? CurrentLevel { get; set; }

    public double? CurrentPressure { get; set; }

    public double? CurrentQtyKg { get; set; }

    public double? CurrentQtyM3 { get; set; }

    public double? FilledQtyaspertankKg { get; set; }

    public double? FilledQtyaspertankM3 { get; set; }

    public double? FilledQtyasperplfKg { get; set; }

    public double? FilledQtyasperplfM3 { get; set; }

    public double? DifferenceKg { get; set; }

    public double? DifferenceM3 { get; set; }

    public int? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public DateOnly? Date { get; set; }

    public virtual DailyTankStatusMaster? DailyTankStatusMaster { get; set; }
}
