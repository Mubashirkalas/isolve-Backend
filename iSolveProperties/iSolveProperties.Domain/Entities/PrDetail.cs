using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PrDetail
{
    public int? Srno { get; set; }

    public int PrNo { get; set; }

    public int GrnNo { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDesc { get; set; }

    public int? Qty { get; set; }

    public double? Value { get; set; }

    public double? Stax { get; set; }

    public virtual GrnMaster GrnNoNavigation { get; set; } = null!;

    public virtual PrMaster PrNoNavigation { get; set; } = null!;
}
