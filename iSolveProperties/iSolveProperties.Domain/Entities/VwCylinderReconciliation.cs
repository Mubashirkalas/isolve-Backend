using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCylinderReconciliation
{
    public byte? SubSegmentId { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public string? Product { get; set; }

    public string? Capacity { get; set; }

    public string? Ownership { get; set; }

    public int? OpeningOk { get; set; }

    public int? OpeningSendTo { get; set; }

    public int? OpeningFilled { get; set; }

    public int? OpeningSales { get; set; }

    public int? ReceivedOk { get; set; }

    public int? ReceivedSendTo { get; set; }

    public int? Filled { get; set; }

    public int? Sales { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? AtcSendto { get; set; }

    public string? BusinessPartnersName { get; set; }
}
