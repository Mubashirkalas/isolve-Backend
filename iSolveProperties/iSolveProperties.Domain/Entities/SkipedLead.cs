using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SkipedLead
{
    public string? CustomerName { get; set; }

    public string? ContactNo { get; set; }

    public short? FromUserId { get; set; }

    public short? ToUserId { get; set; }

    public DateOnly? SkipedDate { get; set; }

    public byte? CompId { get; set; }

    public virtual User? FromUser { get; set; }

    public virtual User? ToUser { get; set; }
}
