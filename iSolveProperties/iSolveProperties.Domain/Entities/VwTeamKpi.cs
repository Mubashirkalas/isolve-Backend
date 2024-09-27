using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTeamKpi
{
    public short? LeaderUserId { get; set; }

    public string? UserName { get; set; }

    public int? DueFollowups { get; set; }

    public int? OverDueFollowups { get; set; }

    public int? UpcomingDueFollowups { get; set; }

    public int? WhatsApped { get; set; }

    public int? Called { get; set; }

    public int? Sms { get; set; }

    public int? MeetingPlanned { get; set; }

    public int? MeetingDone { get; set; }

    public int? FollowupPlanned { get; set; }

    public int? FollowupDone { get; set; }

    public int? TokenDone { get; set; }

    public int? Finalized { get; set; }

    public int? TotalOpportunity { get; set; }

    public int? OpportunityActive { get; set; }

    public int? OpportunityResponded { get; set; }

    public int? OpportunityNotResponded { get; set; }

    public int? OpportunityDropLeads { get; set; }

    public int? ProcessingRegistered { get; set; }

    public int? ProcessingFinalized { get; set; }

    public int? ProcessingDropped { get; set; }

    public int? ProcessingTransferred { get; set; }

    public string? Name { get; set; }

    public string? JobPosition { get; set; }

    public string? LeaderName { get; set; }

    public string? JobDescription { get; set; }
}
