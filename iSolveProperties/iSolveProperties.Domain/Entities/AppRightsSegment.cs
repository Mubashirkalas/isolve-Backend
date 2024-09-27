using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AppRightsSegment
{
    public short? SubSegmentId { get; set; }

    public short? UserId { get; set; }

    public virtual AppRight? User { get; set; }
}
