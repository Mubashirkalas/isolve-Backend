using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwProjectReschedule
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

    public int ProjectSrno { get; set; }

    public string? PropertyDescription { get; set; }

    public string? SubSegmentName { get; set; }

    public short SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public string Reason { get; set; } = null!;

    public string? ProjectInventoryStatusUpdationKey { get; set; }

    public string? Status { get; set; }

    public string? Bpname { get; set; }

    public string? ProjectStatus { get; set; }

    public int? ProjectNo { get; set; }

    public string? ClientName { get; set; }

    public string? ProjectName { get; set; }

    public string? AreaTitle { get; set; }

    public string? MembershipNo { get; set; }

    public string? BlockName { get; set; }

    public short SuserId { get; set; }

    public string? UserName { get; set; }

    public string SuserName { get; set; } = null!;

    public string SworkStation { get; set; } = null!;

    public DateTime ScreationDate { get; set; }
}
