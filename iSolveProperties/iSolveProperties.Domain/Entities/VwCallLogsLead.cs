using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCallLogsLead
{
    public string? PncallLogs { get; set; }

    public DateTime? Time { get; set; }

    public DateTime? Date { get; set; }

    public string? UserName { get; set; }

    public string? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public short? ProjectId { get; set; }

    public string? Project { get; set; }

    public byte? BookingTypeId { get; set; }

    public string? BookingType { get; set; }

    public string? Customer { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Size { get; set; }

    public short? SizeId { get; set; }

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

    public string? BookingFormNo { get; set; }
}
