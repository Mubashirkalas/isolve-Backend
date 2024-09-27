using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwActivityAnalysis
{
    public string? UserName { get; set; }

    public int? NoOfNewOpprotunity { get; set; }

    public int? DueFollowups { get; set; }

    public int? OverDueFollowups { get; set; }

    public int? WhatsApped { get; set; }

    public int? Called { get; set; }

    public int? Meeting { get; set; }

    public int? Sms { get; set; }

    public int? TotalActivities { get; set; }
}
