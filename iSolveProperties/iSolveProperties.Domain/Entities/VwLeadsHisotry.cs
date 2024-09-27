using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLeadsHisotry
{
    public long AutoSerialNo { get; set; }

    public string SerialNo { get; set; } = null!;

    public int CompId { get; set; }

    public string? Remarks { get; set; }

    public DateOnly? FollowUpDate { get; set; }

    public TimeOnly? FollowUpTime { get; set; }

    public string? Status { get; set; }

    public DateTime? CreationTime { get; set; }

    public int? UserId { get; set; }

    public string? Step { get; set; }

    public string? ProjectId { get; set; }

    public string? Project { get; set; }

    public string? BookingTypeId { get; set; }

    public string? BookingType { get; set; }

    public string? Customer { get; set; }

    public string PhoneNumber { get; set; } = null!;

    public string? Size { get; set; }

    public string? SizeId { get; set; }

    public string? City { get; set; }

    public int? Quantity { get; set; }

    public string? DropComment { get; set; }

    public string? UserName { get; set; }
}
