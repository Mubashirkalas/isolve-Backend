using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPurchaseRatesSubSegmentsDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
