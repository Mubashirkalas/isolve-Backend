using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInstrument
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string Keys { get; set; } = null!;

    public short? ProjectId { get; set; }

    public int? DealNo { get; set; }

    public string? InstrumentNo { get; set; }

    public int? InAmount { get; set; }

    public int? OutAmount { get; set; }

    public string? Type { get; set; }

    public string? DealName { get; set; }
}
