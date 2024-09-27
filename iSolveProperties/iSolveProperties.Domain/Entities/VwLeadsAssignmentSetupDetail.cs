using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLeadsAssignmentSetupDetail
{
    public string? SerialNo { get; set; }

    public int? CompId { get; set; }

    public int? Sno { get; set; }

    public int? UserId { get; set; }

    public double? Percentage { get; set; }

    public string? UserName { get; set; }
}
