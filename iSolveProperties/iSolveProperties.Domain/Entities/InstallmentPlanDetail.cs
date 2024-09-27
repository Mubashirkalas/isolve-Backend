using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InstallmentPlanDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public byte? SubSegmentId { get; set; }

    public int? Sno { get; set; }

    public string? ExtraChargesTitle { get; set; }

    public double? ChargesPercentage { get; set; }

    public virtual InstallmentPlan InstallmentPlan { get; set; } = null!;
}
