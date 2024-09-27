using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingFormExtraChargesDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? ExtraChargesSerialNo { get; set; }
}
