using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Log
{
    public string? UserName { get; set; }

    public string? Message { get; set; }

    public DateTime? Time { get; set; }

    public string? PhoneNumber { get; set; }

    public long SerialNo { get; set; }
}
