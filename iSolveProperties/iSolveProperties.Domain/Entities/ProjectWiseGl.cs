using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectWiseGl
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public string? InstallmentPayable { get; set; }

    public string? Discount { get; set; }

    public string? Apaccural { get; set; }

    public string? BookingPayable { get; set; }

    public string? Token { get; set; }

    public string? RentalExpense { get; set; }

    public string? TradingIncome { get; set; }

    public string? Cash { get; set; }

    public string? FileInventory { get; set; }

    public string? Chequesinhand { get; set; }

    public string? ConfirmationPayable { get; set; }

    public string? CommissionExpense { get; set; }

    public string? CommissionIncome { get; set; }

    public string? TradingReceivable { get; set; }

    public string? InstrumentReceivable { get; set; }

    public string? General { get; set; }

    public short? ProjectId { get; set; }

    public string? OtherIncome { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }

    public virtual SubSegment? SubSegment { get; set; }
}
