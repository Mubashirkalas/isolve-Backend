using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDailyTankStatusMaster
{
    public int SerialNo { get; set; }

    public byte? Subsegment { get; set; }

    public string? SubSegmentName { get; set; }

    public DateOnly? Date { get; set; }

    public int SrNo { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;
}
