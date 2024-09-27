using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInstallmentPlanNew
{
    public int SerialNo { get; set; }

    public string? PlanName { get; set; }

    public short? ProjectId { get; set; }

    public short? NoofInstallment { get; set; }

    public string? ProjectName { get; set; }

    public bool WebPlan { get; set; }

    public byte CompId { get; set; }
}
