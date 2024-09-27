using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PurchaseDiscountsBpMain
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string PpNo { get; set; } = null!;

    public string? Bpcode { get; set; }
}
