using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTrading
{
    public int SerialNo { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }

    public string? BookingTypeId { get; set; }

    public string? BookingType { get; set; }

    public string? SizeId { get; set; }

    public string? SizeName { get; set; }

    public string? PhoneNo { get; set; }

    public string? CustomerName { get; set; }

    public int? Amount { get; set; }

    public short? UserId { get; set; }

    public string? UserName { get; set; }

    public string? TradingType { get; set; }

    public byte? Qty { get; set; }

    public byte? CompId { get; set; }

    public string? FileNo { get; set; }

    public short? BlockId { get; set; }

    public string? BlockName { get; set; }

    public int? FileCost { get; set; }

    public int? PurchasedAmount { get; set; }

    public int? SalesAmount { get; set; }

    public int? MembershipFees { get; set; }

    public int? TransferFees { get; set; }

    public int? InstallmentPaid { get; set; }

    public int? StampPaperCharges { get; set; }

    public int? PowerAttorney { get; set; }

    public int? Sod { get; set; }

    public int? MiscExp { get; set; }

    public int? Gpa { get; set; }

    public int? TotalAmount { get; set; }

    public int? TpserialNo { get; set; }

    public string? Remarks { get; set; }

    public DateTime? Date { get; set; }
}
