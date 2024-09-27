using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Lead
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public short? Project { get; set; }

    public byte? BookingType { get; set; }

    public string? City { get; set; }

    public string? Size { get; set; }

    public int? Quantity { get; set; }

    public string? Customer { get; set; }

    public string? Remarks { get; set; }

    public DateOnly? FollowUpDate { get; set; }

    public TimeOnly? FollowUpTime { get; set; }

    public string? Status { get; set; }

    public DateTime? CreationTime { get; set; }

    public string? DropComment { get; set; }

    public int? UserId { get; set; }

    public string? NotificationId { get; set; }

    public string? Step { get; set; }

    public string? SourceOfReference { get; set; }

    public string? WhatsAppNo { get; set; }

    public string? Email { get; set; }

    public int? PlserialNo { get; set; }

    public string? PhoneNo { get; set; }

    public int? Worth { get; set; }

    public string? Occupation { get; set; }

    public string? Company { get; set; }

    public string? Reason { get; set; }

    public string? ActivityType { get; set; }

    public string? AssignUserId { get; set; }

    public string? NextActivity { get; set; }

    public string? ManualSize { get; set; }

    public short? TransferedBy { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
