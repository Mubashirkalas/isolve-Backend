using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class RegionRightsDetail
{
    public int? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? RegionId { get; set; }

    public virtual Region? Region { get; set; }

    public virtual RegionRight? RegionRight { get; set; }
}
