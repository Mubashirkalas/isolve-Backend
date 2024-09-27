using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SupportChargesDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public string? Bpcode { get; set; }

    public int? SupportCharges { get; set; }

    public byte? DueOn { get; set; }

    public virtual SupportCharge SupportCharge { get; set; } = null!;
}
