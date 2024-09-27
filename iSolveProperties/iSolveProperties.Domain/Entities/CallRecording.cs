using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CallRecording
{
    public int SerialNo { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Name { get; set; }

    public DateTime? Time { get; set; }

    public int? UserId { get; set; }

    public string? LocalPath { get; set; }

    public string? Url { get; set; }
}
