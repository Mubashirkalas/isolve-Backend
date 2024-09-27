using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwWarehouse
{
    public string? ItemCode { get; set; }

    public string? ItemGroup { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
