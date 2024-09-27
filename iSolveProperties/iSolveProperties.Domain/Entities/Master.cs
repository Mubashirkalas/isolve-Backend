using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Master
{
    public double? Grnno { get; set; }

    public string? TankNo { get; set; }

    public string? Name { get; set; }

    public string? Type { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Gpno { get; set; }

    public DateOnly? Gpdate { get; set; }

    public string? Party { get; set; }

    public string? Billno { get; set; }

    public string? Ref { get; set; }

    public string? Lot { get; set; }

    public decimal? TotalAmount { get; set; }

    public string KeyField { get; set; } = null!;

    public int? InspNo { get; set; }

    public string Year { get; set; } = null!;

    public string? AccountsKey { get; set; }

    public DateTime? Vdate { get; set; }

    public DateTime? Billdate { get; set; }

    public string? Posted { get; set; }

    public string? SUser { get; set; }

    public int CompId { get; set; }

    public int? TrUserid { get; set; }

    public string? TrWorkstation { get; set; }

    public string? TrUsername { get; set; }

    public DateTime? TrCreationDate { get; set; }

    public string? Staxcode { get; set; }

    public string? MPono { get; set; }

    public string? MDesc { get; set; }

    public bool? IsLocal { get; set; }

    public string? DoNo { get; set; }

    public double? BeforeLevel { get; set; }

    public double? BeforeLevekg { get; set; }

    public double? BeforeLevelm3 { get; set; }

    public double? AfterLevel { get; set; }

    public double? AfterLevelkg { get; set; }

    public double? AfterLevelm3 { get; set; }

    public double? ChartKg { get; set; }

    public double? ChartM3 { get; set; }

    public double? IgprqtyLevelkg { get; set; }

    public double? IgprqtyLevelm3 { get; set; }

    public double? DecantinggainlossKg { get; set; }

    public double? DecantinggainlossM3 { get; set; }
}
