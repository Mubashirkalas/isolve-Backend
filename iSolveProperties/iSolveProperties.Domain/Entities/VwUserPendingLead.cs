using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwUserPendingLead
{
    public short UserId { get; set; }

    public string? UserName { get; set; }

    public string? LeaderName { get; set; }

    public int? LeadNo { get; set; }

    public string? ProjectName { get; set; }

    public string? Source { get; set; }

    public string? CustomerName { get; set; }

    public string? ContactNo { get; set; }

    public string LeadDrop { get; set; } = null!;

    public int? SerialNo { get; set; }

    public string? CreationDate { get; set; }

    public string? Responded { get; set; }

    public string? Registered { get; set; }

    public string? PendingDrop { get; set; }

    public string? AllocatedDate { get; set; }

    public DateTime? Date { get; set; }

    public string? Step { get; set; }

    public string? Remarks { get; set; }

    public string? FollowUpdate { get; set; }

    public string? Nextfollowupdate { get; set; }

    public string? LeadDate { get; set; }

    public int? TotalActivites { get; set; }

    public int? OpportunitySerialNo { get; set; }
}
