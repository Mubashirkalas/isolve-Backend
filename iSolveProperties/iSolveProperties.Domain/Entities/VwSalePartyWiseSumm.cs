using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalePartyWiseSumm
{
    public string? GlCode { get; set; }

    public string GlDesc { get; set; } = null!;

    public string? Unit1 { get; set; }

    public double? Amount { get; set; }

    public double? Qty1 { get; set; }

    public double? Qty2 { get; set; }
}
