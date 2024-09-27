using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingFormDelivery
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public string? Keys { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? DeliveredBy { get; set; }

    public string? PaymentMode { get; set; }

    public int? Cash { get; set; }

    public string? AccountNo { get; set; }

    public int? BankAmount { get; set; }

    public int? InstrumentAmount { get; set; }

    public short? ProjectId { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }
}
