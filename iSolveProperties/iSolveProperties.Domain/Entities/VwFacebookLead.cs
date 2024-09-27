using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFacebookLead
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

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

    public int? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public int? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? ProjectRegistrationName { get; set; }
}
