using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWSaleOrderForQuotationdatum
{
    public byte SubSegmentId { get; set; }

    public string? BpCode { get; set; }

    public string SrNo { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public string? Specification { get; set; }

    public string? Purity { get; set; }

    public double? Qty { get; set; }

    public double? Rpu { get; set; }

    public double? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public double? Discount { get; set; }
}
