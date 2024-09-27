using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPurchaseRatesDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public string? GroupName { get; set; }

    public string? ItemName { get; set; }
}
