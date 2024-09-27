using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBookingFormDelivery
{
    public string Srno { get; set; } = null!;

    public short CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public string? Keys { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? DeliveredBy { get; set; }

    public string? PaymentMode { get; set; }

    public int? Cash { get; set; }

    public string? AccountNo { get; set; }

    public string? BankName { get; set; }

    public int? BankAmount { get; set; }

    public int? InstrumentAmount { get; set; }

    public short? ProjectId { get; set; }

    public string? ProjectName { get; set; }
}
