using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CustomFollowUp
{
    public string? PhoneNumber { get; set; }

    public DateTime? Time { get; set; }

    public int? UserId { get; set; }

    public string? Description { get; set; }

    public long SerialNo { get; set; }
}
