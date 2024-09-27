using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class IgpMaster
{
    public string IgpNo { get; set; } = null!;

    public DateOnly? IgpDate { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public short? SubSegmentId { get; set; }

    public string Keys { get; set; } = null!;

    public short? UserId { get; set; }

    public string? MacAddress { get; set; }

    public string? Srno { get; set; }

    public string? Status { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
