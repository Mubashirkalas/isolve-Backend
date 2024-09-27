using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDosubSegment
{
    public string DoNo { get; set; } = null!;

    public string? SubSegmentName { get; set; }

    public string FYear { get; set; } = null!;

    public byte CompId { get; set; }

    public string Srno { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string BusinessPartnersCode { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }
}
