using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwStatementOfFinancialPosition
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
