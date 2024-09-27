using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSkipedLead
{
    public string? CustomerName { get; set; }

    public string? ContactNo { get; set; }

    public int? FromUserId { get; set; }

    public int? ToUserId { get; set; }

    public DateOnly? SkipedDate { get; set; }

    public byte? CompId { get; set; }

    public string? FromUserName { get; set; }

    public string? ToUserName { get; set; }
}
