using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDeliveryDispatch
{
    public int? SerialNo { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Bpname { get; set; }

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? Bpcode { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Region { get; set; }
}
