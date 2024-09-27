using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LeadAssignmentSetup
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public short? Project { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
