using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCampaignsAnalysis
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int SerialNo { get; set; }

    public DateOnly Date { get; set; }

    public short ProjectId { get; set; }

    public string CampaignName { get; set; } = null!;

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public string? ProjectName { get; set; }
}
