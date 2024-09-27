using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CustomerWiseRateListDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public int? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public virtual CustomerWiseRateList CustomerWiseRateList { get; set; } = null!;
}
