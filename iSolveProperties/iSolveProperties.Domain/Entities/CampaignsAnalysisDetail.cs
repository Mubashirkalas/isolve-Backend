using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CampaignsAnalysisDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short Sno { get; set; }

    public string? SourceName { get; set; }

    public int? TotalBudget { get; set; }

    public int? ActualSpending { get; set; }

    public int? TimePeriod { get; set; }

    public int? AvgPerDaySpending { get; set; }

    public int? TotalLeads { get; set; }

    public int? BetweenAge18To30 { get; set; }

    public int? Between30To40 { get; set; }

    public int? Between40To50 { get; set; }

    public int? Betwek50To60 { get; set; }

    public int? Above60 { get; set; }

    public string? Gender { get; set; }

    public int? TotalConversions { get; set; }

    public virtual CampaignsAnalysis CampaignsAnalysis { get; set; } = null!;
}
