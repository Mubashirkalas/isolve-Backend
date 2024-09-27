using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class QuotationDetail
{
    public byte? SNo { get; set; }

    public string? ItemCode { get; set; }

    public string? Specification { get; set; }

    public string? Purity { get; set; }

    public string? Uom { get; set; }

    public double? Rpu { get; set; }

    public double? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public string SrNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public short? UserId { get; set; }

    public string? ItemGroup { get; set; }

    public double? Qty { get; set; }

    public string? Status { get; set; }

    public double? Discount { get; set; }

    public virtual QuotationMaster QuotationMaster { get; set; } = null!;
}
