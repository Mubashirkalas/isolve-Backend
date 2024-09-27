using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwNewOpportunity
{
    public int SerialNo { get; set; }

    public string? UserName { get; set; }

    public string? AssignedBy { get; set; }

    public string? UploadedBy { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? CustomerName { get; set; }

    public string? ContactNo { get; set; }

    public string? City { get; set; }

    public string? Email { get; set; }

    public string? CompanyName { get; set; }

    public string? ProjectName { get; set; }

    public string? CampaignName { get; set; }

    public string? Remarks { get; set; }

    public string Responded { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string? DropComments { get; set; }

    public short? UserId { get; set; }
}
