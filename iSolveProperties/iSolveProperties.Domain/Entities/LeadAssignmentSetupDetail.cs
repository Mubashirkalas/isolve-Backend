using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LeadAssignmentSetupDetail
{
    public string? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public int? Sno { get; set; }

    public int? UserId { get; set; }

    public double? Percentage { get; set; }

    public virtual LeadAssignmentSetup? LeadAssignmentSetup { get; set; }
}
