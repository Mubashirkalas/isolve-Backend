using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwActivityAnalyser
{
    public int? SerialNo { get; set; }

    public string? PhoneNumber { get; set; }

    public string? UserName { get; set; }

    public DateTime? CreationDate { get; set; }

    public string? Project { get; set; }

    public string? BookingType { get; set; }

    public string? City { get; set; }

    public string? Size { get; set; }

    public string? SourceOfReference { get; set; }

    public string? WhatsAppNo { get; set; }

    public string? Email { get; set; }

    public string? Occupation { get; set; }

    public string? Step { get; set; }

    public string? Status { get; set; }

    public string? DropComment { get; set; }

    public string? Remarks { get; set; }

    public int? TotalFollowups { get; set; }

    public int? UserId { get; set; }
}
