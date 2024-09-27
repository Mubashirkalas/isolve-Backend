using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingFormDeliveryInstrument
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public short? SubSegmentId { get; set; }

    public short? Sno { get; set; }

    public short? ProjectId { get; set; }

    public int? DealNo { get; set; }

    public string? InstrumentNo { get; set; }

    public int? Amount { get; set; }

    public int? BookingFormSrno { get; set; }

    public virtual BookingFormDelivery? BookingFormDelivery { get; set; }
}
