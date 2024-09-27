using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class NewUserRightsSubSegment
{
    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public byte? CompId { get; set; }

    public short? Userid { get; set; }

    public byte? ListIndex { get; set; }
}
