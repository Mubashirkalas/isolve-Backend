using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TeamDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public short? EmployeeId { get; set; }

    public short? Turns { get; set; }

    public virtual User? Employee { get; set; }

    public virtual TeamMaster TeamMaster { get; set; } = null!;
}
