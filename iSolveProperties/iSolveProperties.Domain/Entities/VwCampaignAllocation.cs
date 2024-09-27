using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCampaignAllocation
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? ProjectId { get; set; }

    public string? FormNo { get; set; }

    public int? TeamId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Project { get; set; }

    public bool? InventoryPurchase { get; set; }

    public string? TeamName { get; set; }

    public string? CampaignName { get; set; }

    public string? Source { get; set; }
}
