using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class GrnDetail
{
    public int? Srno { get; set; }

    public int GrnNo { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemDesc { get; set; }

    public int? Qty { get; set; }

    public int? Accepted { get; set; }

    public string? Foc { get; set; }

    public int? Value { get; set; }

    public double? Stax { get; set; }

    public int? Freight { get; set; }

    public int? Packing { get; set; }

    public int? Misc { get; set; }

    public virtual GrnMaster GrnNoNavigation { get; set; } = null!;
}
