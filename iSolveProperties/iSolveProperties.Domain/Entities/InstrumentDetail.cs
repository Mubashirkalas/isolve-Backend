using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InstrumentDetail
{
    public byte? CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public short? Sno { get; set; }

    public string? Keys { get; set; }

    public short? ProjectId { get; set; }

    public int? DealNo { get; set; }

    public string? InstrumentNo { get; set; }

    public int? InAmount { get; set; }

    public int? OutAmount { get; set; }

    public string? Type { get; set; }

    public virtual Instrument? KeysNavigation { get; set; }
}
