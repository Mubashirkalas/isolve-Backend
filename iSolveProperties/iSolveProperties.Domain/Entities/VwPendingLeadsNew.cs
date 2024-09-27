using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingLeadsNew
{
    public int SerialNo { get; set; }

    public string? FormId { get; set; }

    public short? UserId { get; set; }

    public int? EmployeeId { get; set; }

    public string? ContactNo { get; set; }

    public string? City { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? Remarks { get; set; }

    public string? Occupation { get; set; }

    public string? Whatsapp { get; set; }

    public string? CompanyName { get; set; }

    public string? OrganicStatus { get; set; }

    public string? CustomerName { get; set; }

    public string? CreationDate { get; set; }

    public byte? CompId { get; set; }

    public bool? Active { get; set; }

    public string? Status { get; set; }

    public bool? Viewed { get; set; }

    public bool? Responded { get; set; }

    public int? CampaignSerialNo { get; set; }

    public string? CampaignName { get; set; }

    public DateTime? Date { get; set; }

    public string? Source { get; set; }

    public string? LeadType { get; set; }

    public bool? QueueViewed { get; set; }

    public string? Reference { get; set; }

    public int? QueueTeamId { get; set; }

    public bool? QueueCycle { get; set; }

    public string? UserName { get; set; }

    public string? DeviceId { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public string? UploadedBy { get; set; }

    public int? TeamId { get; set; }

    public string? AssignedBy { get; set; }

    public string? TypeName { get; set; }

    public string? DropComments { get; set; }

    public bool? Assigning { get; set; }

    public bool? WebNotification { get; set; }

    public bool? Transferred { get; set; }

    public string? RespondedRemarks { get; set; }
}
