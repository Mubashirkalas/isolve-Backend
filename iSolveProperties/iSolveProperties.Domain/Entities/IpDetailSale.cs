using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class IpDetailSale
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short SubSegmentId { get; set; }

    public string Bpcode { get; set; } = null!;

    public short? Sno { get; set; }

    public string? PostedBy { get; set; }

    public int? DocNo { get; set; }

    public DateOnly? DocDate { get; set; }

    public string? DocType { get; set; }

    public short? SubSegmentIddetail { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public double? SalesTax { get; set; }

    public double? SalesTaxValue { get; set; }

    public double? FurtherTax { get; set; }

    public double? FurtherTaxValue { get; set; }

    public double? TotalValue { get; set; }

    public double? FreightValue { get; set; }

    public double? TotalNetValue { get; set; }

    public string? RouteId { get; set; }

    public string? VehicleId { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? DeliveryAddress { get; set; }

    public string? Status { get; set; }

    public double? CgsValue { get; set; }

    public double? RemainingAmount { get; set; }

    public string? DocKey { get; set; }

    public int? DocSrno { get; set; }

    public short? DocSno { get; set; }

    public short? Whno { get; set; }

    public int? SalesManId { get; set; }

    public string? Remarks { get; set; }

    public byte? PolicyId { get; set; }

    public string? BatchId { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public virtual IpMain IpMain { get; set; } = null!;

    public virtual ItemMaster? ItemMaster { get; set; }

    public virtual Warehouse? Warehouse { get; set; }
}
