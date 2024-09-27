using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPomasterDetail
{
    public string? RequisitionNo { get; set; }

    public DateOnly? RequisitionDate { get; set; }

    public string GroupCode { get; set; } = null!;

    public string? GroupName { get; set; }

    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public byte? SubSegmentCode { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Uom { get; set; }

    public double? BalanceQty { get; set; }

    public double? Qty { get; set; }

    public decimal? Rate { get; set; }

    public decimal? Value { get; set; }

    public int? PoNo { get; set; }

    public DateOnly? PoDate { get; set; }

    public string? Bpcode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? Mop { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public short? SUer { get; set; }

    public string? Terms { get; set; }

    public string? Remarks { get; set; }

    public DateOnly? DelivryDate { get; set; }

    public string? ModeofPacking { get; set; }

    public double? PoDiscountper { get; set; }

    public double? PoStaxper { get; set; }

    public string? ForeignCurrency { get; set; }

    public bool? Import { get; set; }

    public string? SrNo { get; set; }

    public short? PoSubSegmentId { get; set; }

    public string PoSubSegmentName { get; set; } = null!;

    public short? SNo { get; set; }

    public double? Stax { get; set; }

    public double? Discount { get; set; }

    public decimal? TotalValue { get; set; }

    public string? RegisteredOfficeAdress { get; set; }

    public string? Ntn { get; set; }

    public string? Email { get; set; }

    public string? Fax { get; set; }

    public string? Tel1 { get; set; }

    public string? CName { get; set; }

    public string? Address { get; set; }

    public string? Phoneno { get; set; }

    public string? Expr1 { get; set; }

    public byte[]? Pic { get; set; }

    public string? Url { get; set; }

    public string? ContactPerson { get; set; }

    public string? ContactPersonEmail { get; set; }

    public short? RequisitionSno { get; set; }

    public double? ExtraDiscount { get; set; }

    public double? ExciseDuty { get; set; }

    public double? DiscountValue { get; set; }

    public double? ExtraDiscountValue { get; set; }

    public double? ExciseDutyValue { get; set; }

    public double? SalesTaxValue { get; set; }

    public decimal? NetPurchaseRate { get; set; }

    public DateOnly? ValidityDate { get; set; }

    public string? RequisitionKey { get; set; }

    public string? Type { get; set; }

    public string? Status { get; set; }

    public bool? Approved { get; set; }

    public string? RequisitionNo1 { get; set; }

    public DateOnly? RequisitionDate1 { get; set; }
}
