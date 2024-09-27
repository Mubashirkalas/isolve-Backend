using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDosubSegmentOld
{
    public string DoNo { get; set; } = null!;

    public string? SubSegmentName { get; set; }

    public string FYear { get; set; } = null!;

    public byte CompId { get; set; }

    public string Srno { get; set; } = null!;

    public byte SubSegmentId { get; set; }
}
