using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDosubSegmentforIp
{
    public string? DoNo { get; set; }

    public string? DoDate { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? FYear { get; set; }

    public byte? CompId { get; set; }

    public string? BpCode { get; set; }

    public string? Status { get; set; }

    public string? Particulars { get; set; }
}
