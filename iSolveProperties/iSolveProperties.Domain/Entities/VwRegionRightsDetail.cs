using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRegionRightsDetail
{
    public int? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? RegionId { get; set; }

    public string? RegionName { get; set; }

    public short? UserId { get; set; }
}
