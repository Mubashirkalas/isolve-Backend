using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingFormDeliveryDetail
{
    public string? BookingFormNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Keys { get; set; }

    public int? Sno { get; set; }

    public double? Amount { get; set; }

    public int? BookingFormSrno { get; set; }

    public string? ClientName { get; set; }

    public string? City { get; set; }

    public string? VendorCode { get; set; }

    public string? BankAccountNumber { get; set; }

    public double? AmountInCash { get; set; }

    public double? AmountInBank { get; set; }

    public string? BankName { get; set; }

    public int? InstrumentAmount { get; set; }

    public int? AdjustmentAmount { get; set; }

    public string? DealNo { get; set; }

    public string? Project { get; set; }

    public int? PaymentAmount { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public int? Cash { get; set; }

    public string? AccountNo { get; set; }

    public string? BankName1 { get; set; }

    public int? BankAmount { get; set; }

    public int? Expr2 { get; set; }

    public string? ProjectName { get; set; }

    public short? ProjectId { get; set; }

    public string? DeliveredBy { get; set; }

    public string? BookingAgainst { get; set; }

    public string? QuotaStatus { get; set; }

    public string? PaymentMode { get; set; }

    public int? MembershipFee { get; set; }
}
