using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DiscountsMain
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public byte SubSegmentId { get; set; }

    public string PpNo { get; set; } = null!;
}
