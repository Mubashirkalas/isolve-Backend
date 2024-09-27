using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwIpPurchase
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public short SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int IpNo { get; set; }

    public string? IpDate { get; set; }

    public string? PartyType { get; set; }

    public string? AdvanceBal { get; set; }

    public string? InvoiceBal { get; set; }

    public string? SecurityBal { get; set; }

    public string? ApAccuralBal { get; set; }

    public short? SNo { get; set; }

    public string? PostedBy { get; set; }

    public string? DocNo { get; set; }

    public string? DocDate { get; set; }

    public string? DocType { get; set; }

    public double? TotalValue { get; set; }

    public string? DebitMemoNo { get; set; }

    public string? DebitMemoDate { get; set; }

    public double? DebitMemoAmount { get; set; }

    public double? TotalNetValue { get; set; }

    public string BpCode { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public byte SubSegmentId1 { get; set; }

    public string SubSegmentName1 { get; set; } = null!;

    public string? Vin { get; set; }

    public DateOnly? Vid { get; set; }

    public double? SalesTaxReceivable { get; set; }

    public string? Address { get; set; }

    public string? Saletax { get; set; }

    public string? Ntn { get; set; }

    public string? Phoneno { get; set; }

    public string? Fax { get; set; }

    public string? Email { get; set; }

    public byte[]? Pic { get; set; }

    public string? Tel1 { get; set; }

    public string? Cellno { get; set; }

    public string? BpFax { get; set; }

    public string? BpEmail { get; set; }

    public string? RegisteredOfficeAdress { get; set; }

    public string? Url { get; set; }

    public double? Amount { get; set; }

    public double? RemainingAmount { get; set; }

    public string? Expr1 { get; set; }

    public string? Strn { get; set; }

    public DateOnly? IpDate1 { get; set; }

    public double? AdvanceBal1 { get; set; }

    public double? InvoiceBal1 { get; set; }

    public string? SecurityBal1 { get; set; }

    public string? ApaccuralBal1 { get; set; }

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

    public string? Whname { get; set; }

    public string? ItemName { get; set; }

    public string? GroupName { get; set; }

    public string? Status { get; set; }

    public string? PaidBy { get; set; }

    public string? BatchNo { get; set; }

    public short? Userid { get; set; }

    public string? UserName { get; set; }
}
