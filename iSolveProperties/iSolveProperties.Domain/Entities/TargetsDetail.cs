using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TargetsDetail
{
    public int? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public short? UserId { get; set; }

    public short? ProjectRegistrationSerialNo { get; set; }

    public int? Target { get; set; }

    public int? TargetValue { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }

    public virtual Target? TargetNavigation { get; set; }

    public virtual User? User { get; set; }
}
