using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class IpDetailPurchase
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string IpNo { get; set; } = null!;

    public string BpCode { get; set; } = null!;

    public short? Sno { get; set; }

    public string? PostedBy { get; set; }

    public string? DocNo { get; set; }

    public DateOnly? DocDate { get; set; }

    public string? DocType { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? DebitMemoNo { get; set; }

    public DateOnly? DebitMemoDate { get; set; }

    public double? DebitMemoAmount { get; set; }

    public double? TotalNetValue { get; set; }

    public string? Vin { get; set; }

    public DateOnly? Vid { get; set; }

    public double? RemainingAmount { get; set; }

    public double? Amount { get; set; }

    public string? Status { get; set; }

    public double? SalesTax { get; set; }

    public string? DocKey { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDuty { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTaxValue { get; set; }

    public double? FreightValue { get; set; }

    public byte? Whno { get; set; }

    public string? PaidBy { get; set; }

    public string? BatchNo { get; set; }

    public virtual IpMain IpMain { get; set; } = null!;

    public virtual ItemMaster? ItemMaster { get; set; }
}
