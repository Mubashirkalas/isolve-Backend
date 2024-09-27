using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBusinessPartnersSubSegment
{
    public int SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int CompId { get; set; }

    public string BusinessPartnersCode { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }
}
