using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PurchaseRatesSubSegmentsDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte? SubSegmentId { get; set; }
}
