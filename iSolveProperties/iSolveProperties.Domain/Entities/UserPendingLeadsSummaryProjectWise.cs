using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class UserPendingLeadsSummaryProjectWise
{
    public short UserId { get; set; }

    public string? UserName { get; set; }

    public string UserType { get; set; } = null!;

    public int? TotalPendingLeads { get; set; }

    public int? RemainingLead { get; set; }

    public int? DroppedPendingLead { get; set; }

    public int AssignedLead { get; set; }

    public int? Registered { get; set; }

    public int? DroppedRegistered { get; set; }

    public int? FinalizedRegitered { get; set; }

    public string? Pendingfollowup { get; set; }

    public string? Followedup { get; set; }

    public string? FollowupDays { get; set; }

    public string? ConversionRatio { get; set; }

    public string? PendingDropRatio { get; set; }

    public string? ActiveDropRatio { get; set; }

    public string? ResponseTime { get; set; }

    public short? ProjectId { get; set; }

    public string? Project { get; set; }
}
