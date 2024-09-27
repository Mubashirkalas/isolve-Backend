using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LcLandedCost
{
    public int Lcc { get; set; }

    public byte CompId { get; set; }

    public string? LcName { get; set; }

    public string? ControlAccount { get; set; }
}
