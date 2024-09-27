using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LcmanagementWithLcc
{
    public short? LccsrNo { get; set; }

    public int? LcCode { get; set; }

    public string? Description { get; set; }

    public string? PartyCode { get; set; }

    public double? AmountPayable { get; set; }

    public string? Keys { get; set; }

    public virtual LcmanagementMain? KeysNavigation { get; set; }
}
