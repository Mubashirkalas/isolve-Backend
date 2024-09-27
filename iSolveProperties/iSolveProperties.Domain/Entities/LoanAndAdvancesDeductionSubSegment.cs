using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LoanAndAdvancesDeductionSubSegment
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public byte? SubSegmentId { get; set; }

    public virtual LoanAndAdvancesDeductionSetup LoanAndAdvancesDeductionSetup { get; set; } = null!;
}
