using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLeadsActivitySummary
{
    public short UserId { get; set; }

    public string? UserName { get; set; }

    public string? TotalLeads { get; set; }

    public string? FollowupDays { get; set; }

    public string? ConversionRatio { get; set; }

    public string? ResponseTime { get; set; }

    public string? AvgvisitFinalized { get; set; }

    public string? AvgVisitDays { get; set; }

    public string? AvgSalesDays { get; set; }

    public string? TotalAssignedLeads { get; set; }

    public string? PendingDropRatio { get; set; }

    public string? ActiveDropRatio { get; set; }

    public int? DropActiveLeads { get; set; }

    public int? PendingDropLeads { get; set; }

    public string? UnRegistered { get; set; }

    public string? Assigned { get; set; }

    public string? Tmleads { get; set; }
}
