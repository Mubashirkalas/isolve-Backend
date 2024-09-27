using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTradingPayment
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? TradingSerialNo { get; set; }

    public string? ProjectName { get; set; }

    public string? BookingType { get; set; }

    public string? SizeName { get; set; }

    public string? CustomerName { get; set; }

    public string? PhoneNo { get; set; }

    public int? TradingAmount { get; set; }

    public string? BlockName { get; set; }

    public string? FileNo { get; set; }

    public int? Amount { get; set; }

    public string? AccountNo { get; set; }

    public string? BankName { get; set; }

    public string? PaymentMode { get; set; }

    public string? UserName { get; set; }

    public int? TotalAmount { get; set; }

    public string? Remarks { get; set; }

    public int? RemainingAmount { get; set; }

    public string? PreparedBy { get; set; }

    public string? PaymentType { get; set; }

    public short? ProjectId { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDate { get; set; }
}
