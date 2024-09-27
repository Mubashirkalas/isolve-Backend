using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class IgpDetail
{
    public short? SrNo { get; set; }

    public string? Type { get; set; }

    public string? PoNo { get; set; }

    public DateOnly? PoDate { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public int? GinNo { get; set; }

    public DateOnly? GinDate { get; set; }

    public string? DlCode { get; set; }

    public DateOnly? DlDate { get; set; }

    public double? ReceiveQty { get; set; }

    public string? VehicleNo { get; set; }

    public string? DriverName { get; set; }

    public string? CellNo { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public string? BpCode { get; set; }

    public string? Keys { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? Status { get; set; }

    public double? Rate { get; set; }

    public decimal? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public decimal? TotalValue { get; set; }

    public string? PoKey { get; set; }

    public double? ActualQty { get; set; }

    public double? QtyConsumed { get; set; }

    public short? PoSno { get; set; }

    public string? TypePo { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExciseDuty { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTaxValue { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual ItemMaster? ItemMaster { get; set; }

    public virtual IgpMaster? KeysNavigation { get; set; }
}
