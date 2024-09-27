using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuotationDetail
{
    public byte? SNo { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Specification { get; set; }

    public string? Purity { get; set; }

    public string? Uom { get; set; }

    public double? Rpu { get; set; }

    public string? Value { get; set; }

    public string? SalesTax { get; set; }

    public string? FurtherTax { get; set; }

    public string? TotalValue { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public string SrNo { get; set; } = null!;

    public double? Qty { get; set; }

    public double? Discount { get; set; }
}
