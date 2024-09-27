using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FollowupDetail
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

    public DateOnly? NextFollowupdate { get; set; }

    public DateTime? NextFollowuptime { get; set; }

    public short? Days { get; set; }

    public bool? FirstFollowup { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }

    public string? NextActivity { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
