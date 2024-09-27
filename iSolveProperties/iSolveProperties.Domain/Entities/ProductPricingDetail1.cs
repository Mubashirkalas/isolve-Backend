using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProductPricingDetail1
{
    public int Srno { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public double? OldRate { get; set; }

    public double? MarketRate { get; set; }

    public virtual ProductPricingMaster ProductPricingMaster { get; set; } = null!;
}
