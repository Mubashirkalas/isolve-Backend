using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDailyTankStatusReport
{
    public int SerialNo { get; set; }

    public byte? Subsegment { get; set; }

    public DateOnly? Date { get; set; }

    public int SrNo { get; set; }

    public byte CompanyId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SubSegmentName { get; set; }

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
}
