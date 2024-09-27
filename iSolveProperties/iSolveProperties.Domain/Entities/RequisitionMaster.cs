using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class RequisitionMaster
{
    public string? PiNo { get; set; }

    public DateOnly? PiDate { get; set; }

    public string? CcCode { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public int? SUser { get; set; }

    public byte CompId { get; set; }

    public string? ReqType { get; set; }

    public short? SubSegmentId { get; set; }

    public string? SrNo { get; set; }

    public string? Status { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
