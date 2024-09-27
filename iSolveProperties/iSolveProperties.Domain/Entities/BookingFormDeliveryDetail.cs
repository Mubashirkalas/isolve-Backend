using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingFormDeliveryDetail
{
    public string Srno { get; set; } = null!;

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Keys { get; set; }

    public int? Sno { get; set; }

    public int? BookingFormSrno { get; set; }

    public double? Amount { get; set; }

    public string? PaymentMode { get; set; }

    public string? BankAccountNumber { get; set; }

    public double? AmountInCash { get; set; }

    public double? AmountInBank { get; set; }

    public string? InstrumentNo { get; set; }

    public string? DealNo { get; set; }

    public int? AdjustmentAmount { get; set; }

    public int? InstrumentAmount { get; set; }

    public int? PaymentAmount { get; set; }

    public virtual BookingForm? BookingForm { get; set; }

    public virtual BookingFormDelivery? BookingFormDelivery { get; set; }
}
