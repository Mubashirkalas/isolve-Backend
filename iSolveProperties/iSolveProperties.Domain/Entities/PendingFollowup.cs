using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PendingFollowup
{
    public int SerialNo { get; set; }

    public string? PhoneNo { get; set; }

    public DateOnly? FollowUpdate { get; set; }

    public DateTime? Followuptime { get; set; }

    public string? Step { get; set; }

    public string? Status { get; set; }

    public short? ProjectId { get; set; }

    public string? SizeId { get; set; }

    public string? City { get; set; }

    public string? Type { get; set; }

    public int? LeadSerialNo { get; set; }

    public string? Remarks { get; set; }

    public byte? CompId { get; set; }

    public bool? Active { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
