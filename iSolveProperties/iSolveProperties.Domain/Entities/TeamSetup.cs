using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TeamSetup
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Bpcode { get; set; }

    public double? Commission { get; set; }

    public double? CommissionValue { get; set; }

    public DateOnly? ApplicableDate { get; set; }

    public string? Project { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }
}
