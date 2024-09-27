using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Podetail
{
    public short? Srno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public double? PoQtyord { get; set; }

    public decimal? PoRate { get; set; }

    public decimal? PoValue { get; set; }

    public string? RequisitionNo { get; set; }

    public string? Keys { get; set; }

    public string? Year { get; set; }

    public int? PoNo { get; set; }

    public byte? CompId { get; set; }

    public DateOnly? RequisitionDate { get; set; }

    public double? BalanceQty { get; set; }

    public string? Uom { get; set; }

    public string? Status { get; set; }

    public byte? SubSegmentId { get; set; }

    public double? Stax { get; set; }

    public double? Discount { get; set; }

    public decimal? TotalValue { get; set; }

    public string? RequisitionKey { get; set; }

    public double? ActualQty { get; set; }

    public double? QtyConsumed { get; set; }

    public short? RequisitionSno { get; set; }

    public string? Type { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExciseDuty { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTaxValue { get; set; }

    public decimal? NetPurchaseRate { get; set; }

    public virtual ItemMaster? ItemMaster { get; set; }

    public virtual Pomaster? Pomaster { get; set; }
}
