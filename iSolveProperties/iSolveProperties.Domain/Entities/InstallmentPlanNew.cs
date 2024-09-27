using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InstallmentPlanNew
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? ProjectId { get; set; }

    public short? NoofInstallment { get; set; }

    public string? PlanName { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public DateTime? McreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public bool WebPlan { get; set; }
}
