using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class UsersActiveTime
{
    public long AutoSerialNo { get; set; }

    public short? UserId { get; set; }

    public DateOnly? Date { get; set; }

    public double? ActiveTimeInMinutes { get; set; }

    public virtual User? User { get; set; }
}
