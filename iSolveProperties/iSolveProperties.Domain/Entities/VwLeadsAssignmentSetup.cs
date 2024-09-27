using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLeadsAssignmentSetup
{
    public string SerialNo { get; set; } = null!;

    public int CompId { get; set; }

    public string? Project { get; set; }

    public string? ProjectTitle { get; set; }
}
