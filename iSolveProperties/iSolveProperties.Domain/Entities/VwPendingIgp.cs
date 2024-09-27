using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingIgp
{
    public string IgpNo { get; set; } = null!;

    public string? IgpDate { get; set; }

    public string? PoNo { get; set; }

    public string? PoDate { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public decimal? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public decimal? TotalValue { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string ItemGroup { get; set; } = null!;

    public string? ItDesc { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public short SubSegmentIgp { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public string? Status { get; set; }

    public string? DlDate { get; set; }

    public string? DlCode { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public short? SrNo { get; set; }

    public double? Qty { get; set; }

    public string SubSegmentIgpname { get; set; } = null!;

    public string? TypePo { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExciseDuty { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTaxValue { get; set; }
}
