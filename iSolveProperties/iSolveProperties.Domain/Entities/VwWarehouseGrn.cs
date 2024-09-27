using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwWarehouseGrn
{
    public byte? Whno { get; set; }

    public string? Whname { get; set; }

    public string? ItemCode { get; set; }

    public byte? CompId { get; set; }

    public string? ItemGroup { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Whlocation { get; set; }

    public string? Whaddress { get; set; }
}
