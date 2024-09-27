using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DuplicatePendingLead
{
    public int SerialNo { get; set; }

    public string? FormId { get; set; }

    public short? UserId { get; set; }

    public int? EmployeeId { get; set; }

    public string? CustomerName { get; set; }

    public string? ContactNo { get; set; }

    public string? City { get; set; }

    public int? TeamId { get; set; }

    public short? ProjectId { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? Remarks { get; set; }

    public string? OrganicStatus { get; set; }

    public string? Occupation { get; set; }

    public string? Whatsapp { get; set; }

    public string? CompanyName { get; set; }

    public byte? CompId { get; set; }

    public bool? Active { get; set; }

    public string? Status { get; set; }

    public bool? Viewed { get; set; }

    public bool? Cycle { get; set; }

    public string? UncontactNo { get; set; }

    public bool? Responded { get; set; }

    public int? CampaignSerialNo { get; set; }

    public bool? QueueCycle { get; set; }

    public int? QueueTeamId { get; set; }

    public string? Reference { get; set; }

    public bool? QueueViewed { get; set; }

    public string? LeadType { get; set; }
}
