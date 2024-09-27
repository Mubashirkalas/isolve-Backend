using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLcLandedCost1
{
    public short? LccsrNo { get; set; }

    public int? LcCode { get; set; }

    public string? LcName { get; set; }

    public string? PartyCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public double? AmountPayable { get; set; }

    public string? Keys { get; set; }

    public string? Description { get; set; }
}
