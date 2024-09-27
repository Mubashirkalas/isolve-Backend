using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DealPurchaseInstrument
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public short? SubSegmentId { get; set; }

    public int? DealNo { get; set; }

    public short? ProjectId { get; set; }

    public string? InstrumentNo { get; set; }

    public int? Amount { get; set; }

    public virtual DealPurchase DealPurchase { get; set; } = null!;
}
