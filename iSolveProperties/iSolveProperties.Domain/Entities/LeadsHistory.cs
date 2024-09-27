using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LeadsHistory
{
    public long AutoSerialNo { get; set; }

    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Remarks { get; set; }

    public DateOnly? FollowUpDate { get; set; }

    public TimeOnly? FollowUpTime { get; set; }

    public string? Status { get; set; }

    public DateTime? CreationTime { get; set; }

    public int? UserId { get; set; }

    public string? Step { get; set; }
}
