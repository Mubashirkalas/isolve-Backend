using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Igpdetail1
{
    public int? Srno { get; set; }

    public string? Type { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public string? GateInNo { get; set; }

    public DateOnly? GateInDate { get; set; }

    public string? DeliveryChallanNo { get; set; }

    public DateOnly? DeliveryChallanDate { get; set; }

    public double? ReceiveQty { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public string? Keys { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? Status { get; set; }

    public double? Rate { get; set; }

    public decimal? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public decimal? TotalValue { get; set; }

    public double? OrderedQty { get; set; }

    public short? Posno { get; set; }

    public string? TypePo { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExciseDuty { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTaxValue { get; set; }

    public short? Sno { get; set; }

    public short? JuteQty { get; set; }

    public short? Ppqty { get; set; }

    public virtual Igpmaster1? KeysNavigation { get; set; }
}
