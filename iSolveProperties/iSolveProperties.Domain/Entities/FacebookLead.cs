using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FacebookLead
{
    public byte? CompId { get; set; }

    public int SerialNo { get; set; }

    public string? AddFromId { get; set; }

    public string? Name { get; set; }

    public string? ContactNumber { get; set; }

    public string? City { get; set; }

    public string? Occupation { get; set; }

    public string? WhatsappNumber { get; set; }

    public string? CompanyName { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public string? ProjectRegistrationSerialNo { get; set; }

    public string? OrganicStatus { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public int? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? Type { get; set; }

    public short? ProjectId { get; set; }

    public short? TeamId { get; set; }

    public short? LeadType { get; set; }

    public virtual User? Suser { get; set; }
}
