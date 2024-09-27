using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGrnmasterDetailNew
{
    public int? Grnno { get; set; }

    public string? Type { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Bpcode { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public int? Srno { get; set; }

    public string? GrnVoucherKey { get; set; }

    public string? Status { get; set; }

    public int? GrnReturnNo { get; set; }

    public long SerialNo { get; set; }

    public string? BuiltyNo { get; set; }

    public string? Recievername { get; set; }

    public DateOnly? BuiltyDate { get; set; }

    public string? FreightType { get; set; }

    public string? PaymentMode { get; set; }

    public string? PaidBy { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? GroupCode { get; set; }

    public string? BpCode1 { get; set; }

    public double? PrimaryQty { get; set; }

    public double? IssueQty { get; set; }

    public string? PrimaryUom { get; set; }

    public decimal? PrimaryRate { get; set; }

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

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public string? DeptCode { get; set; }

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

    public DateOnly? GrnDate1 { get; set; }

    public decimal? TotalValueSin { get; set; }

    public string? IgpKeys { get; set; }

    public string? VehicleId { get; set; }

    public double? DemandQty { get; set; }

    public double? OtherOverheads { get; set; }

    public short? DetailSrno { get; set; }

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

    public string? BusinessPartnersName { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Whname { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public string? Remarks { get; set; }

    public string? InvoiceNo { get; set; }

    public string? CompanyName { get; set; }

    public decimal? FreightAmount { get; set; }

    public DateOnly? InvoiceDate { get; set; }

    public short? Igpsno { get; set; }

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public double? PurchaseQty { get; set; }

    public decimal? Rate { get; set; }

    public string? Uom { get; set; }

    public double? FreightValue { get; set; }

    public string? Whtkey { get; set; }

    public string? Igptype { get; set; }

    public string? BatchNo { get; set; }
}
