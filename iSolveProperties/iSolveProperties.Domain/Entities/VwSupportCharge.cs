using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSupportCharge
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? SubSegmentName { get; set; }
}
