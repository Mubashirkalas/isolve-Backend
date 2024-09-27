using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LeaveRulesSubSegmentsDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public byte? SubSegmentId { get; set; }

    public virtual LeaveRulesDefinition LeaveRulesDefinition { get; set; } = null!;
}
