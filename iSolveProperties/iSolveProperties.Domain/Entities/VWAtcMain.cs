using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWAtcMain
{
    public string Keys { get; set; } = null!;

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public int? AtcNo { get; set; }

    public DateOnly? AtcDate { get; set; }

    public string? SubSegmentName { get; set; }
}
