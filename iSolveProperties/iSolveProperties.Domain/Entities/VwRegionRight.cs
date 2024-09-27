using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRegionRight
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public short? UserId { get; set; }

    public string? UserName { get; set; }
}
