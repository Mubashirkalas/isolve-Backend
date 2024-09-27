using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AttendanceLocation
{
    public short SerialNo { get; set; }

    public short SubSegmentId { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }
}
