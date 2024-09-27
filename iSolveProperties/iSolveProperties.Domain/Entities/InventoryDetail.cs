using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InventoryDetail
{
    public string ItemCode { get; set; } = null!;

    public string? GroupCode { get; set; }

    public string? BpCode { get; set; }

    public short? SubSegmentId { get; set; }

    public double? PurchaseQty { get; set; }

    public double? IssueQty { get; set; }

    public string? Uom { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public decimal? TotalValue { get; set; }

    public int? Igpno { get; set; }

    public DateOnly? Igpdate { get; set; }

    public int? Pono { get; set; }

    public DateOnly? Podate { get; set; }

    public string? Dcno { get; set; }

    public DateOnly? Dcdate { get; set; }

    public string? DrRequisition { get; set; }

    public DateOnly? DrRequisitionDate { get; set; }

    public string? Type { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public string? DeptCode { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public short? WarehouseNo { get; set; }

    public short? WarehouseSubsegmentId { get; set; }

    public double? QtyInStock { get; set; }

    public string? DrRequistionKeys { get; set; }

    public double? RemainingQty { get; set; }

    public decimal? RemainingRate { get; set; }

    public decimal? RemainingValue { get; set; }

    public byte? ToWareHouseNo { get; set; }

    public byte? ToWareHouseSubSegmentId { get; set; }

    public double? TransportationCharges { get; set; }

    public double? ExciseValue { get; set; }

    public string? VehicleRegistration { get; set; }

    public short? SubSegmentIdMain { get; set; }

    public DateOnly? GrnDate { get; set; }

    public decimal? TotalValueSin { get; set; }

    public string? IgpKeys { get; set; }

    public string? VehicleId { get; set; }

    public double? DemandQty { get; set; }

    public double? OtherOverheads { get; set; }

    public short? DetailSrno { get; set; }

    public string? Remarks { get; set; }

    public decimal? NetPurchaseRate { get; set; }

    public long DetailSno { get; set; }

    public double? RemQty { get; set; }

    public double? StockCheck { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDuty { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTaxValue { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public short? Igpsno { get; set; }

    public double? ActualQty { get; set; }

    public decimal? ActualRate { get; set; }

    public string? ActualUom { get; set; }

    public double? FreightValue { get; set; }

    public string? Status { get; set; }

    public string? Whtkey { get; set; }

    public string? BatchNo { get; set; }

    public virtual ItemMaster? ItemMaster { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
