using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CylinderReconciliation
{
    public byte? SubSegmentId { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public string? Product { get; set; }

    public string? Capacity { get; set; }

    public string? Ownership { get; set; }

    public int? EcrOk { get; set; }

    public int? EcrSendTo { get; set; }

    public DateOnly? Date { get; set; }

    public string? SerialNo { get; set; }

    public int? AtcSendTo { get; set; }

    public int? CfsOk { get; set; }

    public string? Type { get; set; }

    public string? BpCode { get; set; }
}
