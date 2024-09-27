using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTargetvsAch
{
    public short? UserId { get; set; }

    public string? UserName { get; set; }

    public short? ProjectRegistrationSerialNo { get; set; }

    public string? ProjectName { get; set; }

    public string? Monthly { get; set; }

    public int? Target { get; set; }

    public int LeadsAchieved { get; set; }
}
