using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLead
{
    public DateTime? Date { get; set; }

    public string? UserName { get; set; }

    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public short? ProjectId { get; set; }

    public string? Project { get; set; }

    public byte? BookingTypeId { get; set; }

    public string? BookingType { get; set; }

    public string? Customer { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Size { get; set; }

    public string? SizeId { get; set; }

    public string? City { get; set; }

    public int? Quantity { get; set; }

    public DateOnly? FollowUpDate { get; set; }

    public TimeOnly? FollowUpTime { get; set; }

    public DateTime? CreationTime { get; set; }

    public string? Step { get; set; }

    public string? Status { get; set; }

    public string? DropComment { get; set; }

    public int? UserId { get; set; }

    public string? Remarks { get; set; }

    public string? SourceOfReference { get; set; }

    public DateTime? DateOnly { get; set; }

    public string? WhatsAppNo { get; set; }

    public string? Email { get; set; }

    public string? DropComments { get; set; }

    public string? Occupation { get; set; }

    public short? TransferedBy { get; set; }

    public string? NextActivity { get; set; }

    public string? AssignUserId { get; set; }

    public string? ActivityType { get; set; }

    public string? Company { get; set; }

    public string? PhoneNo { get; set; }

    public int? PlserialNo { get; set; }

    public string? ManualSize { get; set; }
}
