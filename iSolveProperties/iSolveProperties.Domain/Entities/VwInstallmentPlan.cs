using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInstallmentPlan
{
    public byte CompId { get; set; }

    public string SerialNo { get; set; } = null!;

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public short? ProjectSerialNo { get; set; }

    public string? ProjectName { get; set; }

    public double? TimePeriod { get; set; }

    public string? Advance { get; set; }

    public string? Confirmation { get; set; }

    public int? DaysAfterBooking { get; set; }

    public byte? NoOfInstallments { get; set; }

    public string? InstallmentPlans { get; set; }

    public string? Installment { get; set; }

    public byte? NumberOfDue { get; set; }

    public string? DuePlan { get; set; }

    public string? Due { get; set; }

    public string? DevelopmentCharges { get; set; }

    public string? OnPossession { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? DevelopmentChargesSchedule { get; set; }

    public string? PlanName { get; set; }

    public string? LateChargesPerDay { get; set; }

    public string? AmountOrPercentage { get; set; }

    public string? Excavation { get; set; }

    public int? ExcavationDab { get; set; }
}
