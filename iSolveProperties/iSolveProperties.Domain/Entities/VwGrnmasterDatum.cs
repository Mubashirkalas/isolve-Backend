using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGrnmasterDatum
{
    public string SubSegmentName { get; set; } = null!;

    public int? Grnno { get; set; }

    public DateOnly? Grndate { get; set; }

    public short? SubSegmentId { get; set; }

    public string Keys { get; set; } = null!;

    public string? Bpcode { get; set; }

    public bool? Approved { get; set; }

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }
}
