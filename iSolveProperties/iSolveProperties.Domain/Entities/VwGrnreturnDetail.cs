using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGrnreturnDetail
{
    public short? Sno { get; set; }

    public string? Whname { get; set; }

    public string? ItemName { get; set; }

    public string? GroupName { get; set; }

    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public double? Qty { get; set; }

    public double? Value { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDuty { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTax { get; set; }

    public double? SalesTaxValue { get; set; }

    public double? TotalValue { get; set; }

    public double? FreightValue { get; set; }

    public byte? Whno { get; set; }

    public string? Keys { get; set; }

    public double? ToBeDeliveredQty { get; set; }

    public string? Grnkeys { get; set; }

    public short? Grnsno { get; set; }

    public string? BatchNo { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? Bpcode { get; set; }

    public short? SubSegmentId { get; set; }
}
