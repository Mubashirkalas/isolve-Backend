using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwIncentiveManagementInvoiceDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? Ipsrno { get; set; }

    public string? Ipno { get; set; }

    public byte? IpsubSegment { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? TotalValue { get; set; }

    public double? IncentiveValue { get; set; }

    public double? ReturnValue { get; set; }

    public string? ItemName { get; set; }

    public string? GroupName { get; set; }

    public string IpsubSegmentName { get; set; } = null!;

    public double? SalesTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalFreight { get; set; }

    public double? DiscountPercentage { get; set; }

    public double? DiscountValue { get; set; }
}
