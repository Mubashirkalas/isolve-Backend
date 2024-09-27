using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TeamSetupDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Bpcode { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }

    public virtual TeamSetup TeamSetup { get; set; } = null!;
}
