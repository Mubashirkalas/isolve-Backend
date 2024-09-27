using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TeamMaster
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public string? TeamName { get; set; }

    public short? SubSegmentId { get; set; }

    public virtual ICollection<PendingLeadsNew> PendingLeadsNews { get; set; } = new List<PendingLeadsNew>();
}
