using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CallLog
{
    public string? PhoneNumber { get; set; }

    public string? Name { get; set; }

    public DateTime? Time { get; set; }

    public int? UserId { get; set; }

    public long SerialNo { get; set; }
}
