using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CnfrmtionPymentDetail
{
    public int? Srno { get; set; }

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

    public virtual BookingForm? BookingForm { get; set; }

    public virtual CnfrmtionPyment? CnfrmtionPyment { get; set; }
}
