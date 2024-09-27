using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSocietyPaymentDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Keys { get; set; }

    public int? Sno { get; set; }

    public int? BookingFormSrno { get; set; }

    public int? Amount { get; set; }

    public int? AmountInCash { get; set; }

    public int? AmountInBank { get; set; }

    public int? AdjustmentAmount { get; set; }

    public int? InstrumentAmount { get; set; }

    public string? BankAccountNumber { get; set; }

    public string? PaymentMode { get; set; }

    public string? DealNo { get; set; }

    public string? BankName { get; set; }

    public string? ClientName { get; set; }

    public string? BookingFormNo { get; set; }

    public double Payment { get; set; }

    public string? VendorCode { get; set; }

    public string? Project { get; set; }

    public string? ProjectName { get; set; }

    public string? ProjectId { get; set; }

    public string? SocietyInstallmentSrno { get; set; }
}
