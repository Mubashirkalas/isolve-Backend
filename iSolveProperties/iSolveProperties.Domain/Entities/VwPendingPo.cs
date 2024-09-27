using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingPo
{
    public int? PoNo { get; set; }

    public string? PoDate { get; set; }

    public string? Bpcode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemName { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public double? PoQtyord { get; set; }

    public decimal? PoRate { get; set; }

    public decimal? PoValue { get; set; }

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Status { get; set; }

    public bool? Import { get; set; }

    public string ItemGroup { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public decimal? TotalValue { get; set; }

    public double? Discount { get; set; }

    public double? Stax { get; set; }

    public double? BalanceQty { get; set; }

    public string? Uom { get; set; }

    public short SubSegmentIdpomaster { get; set; }

    public double ConsumedQty { get; set; }

    public short? Srno { get; set; }

    public string? Type { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExciseDuty { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTaxValue { get; set; }

    public bool? Approved { get; set; }

    public string Keys { get; set; } = null!;

    public double ReceivedQty { get; set; }
}
