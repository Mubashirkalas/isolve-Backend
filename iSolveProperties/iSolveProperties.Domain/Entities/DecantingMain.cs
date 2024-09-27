using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DecantingMain
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public int? DecantingNo { get; set; }

    public DateOnly? DecantingDate { get; set; }

    public string? TankNo { get; set; }

    public double? BeforeLevel { get; set; }

    public double? BeforePressure { get; set; }

    public double? BeforeKg { get; set; }

    public double? BeforeM3 { get; set; }

    public double? BeforeLtr { get; set; }

    public double? AfterLevel { get; set; }

    public double? AfterPressure { get; set; }

    public double? AfterKg { get; set; }

    public double? AfterM3 { get; set; }

    public double? AfterLtr { get; set; }

    public double? ChartKg { get; set; }

    public double? ChartM3 { get; set; }

    public double? ChartLtr { get; set; }

    public double? IgpKg { get; set; }

    public double? IgpM3 { get; set; }

    public double? IgpLtr { get; set; }

    public double? DecantingKg { get; set; }

    public double? DecantingM3 { get; set; }

    public double? DecantingLtr { get; set; }

    public string? TankTwo { get; set; }

    public double? BeforeLevelTankTwo { get; set; }

    public double? BeforePressureTankTwo { get; set; }

    public double? BeforeKgTankTwo { get; set; }

    public double? BeforeM3TankTwo { get; set; }

    public double? BeforeLtrTankTwo { get; set; }

    public double? AfterLevelTankTwo { get; set; }

    public double? AfterPressureTankTwo { get; set; }

    public double? AfterKgTankTwo { get; set; }

    public double? AfterM3TankTwo { get; set; }

    public double? AfterLtrTankTwo { get; set; }

    public double? ChartKgTankTwo { get; set; }

    public double? ChartM3TankTwo { get; set; }

    public double? ChartLtrTankTwo { get; set; }

    public string? Type { get; set; }
}
