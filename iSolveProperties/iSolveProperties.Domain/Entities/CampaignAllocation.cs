using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CampaignAllocation
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? ProjectId { get; set; }

    public string? FormNo { get; set; }

    public int? TeamId { get; set; }

    public DateOnly? Date { get; set; }

    public string? CampaignName { get; set; }

    public string? Source { get; set; }

    public int? QueueTeamId { get; set; }

    public virtual ICollection<PendingLeadsNew> PendingLeadsNews { get; set; } = new List<PendingLeadsNew>();

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
