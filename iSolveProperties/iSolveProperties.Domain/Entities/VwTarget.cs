using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTarget
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public short? UserId { get; set; }

    public short? ProjectRegistrationSerialNo { get; set; }

    public int? Target { get; set; }

    public string? ProjectName { get; set; }

    public string? UserName { get; set; }

    public string? Monthly { get; set; }

    public int? TargetValue { get; set; }
}
