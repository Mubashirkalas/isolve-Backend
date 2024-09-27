using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLcCfLandedCost
{
    public short? CfsrNo { get; set; }

    public DateOnly? CfDate { get; set; }

    public int? CfLccode { get; set; }

    public string? LcName { get; set; }

    public string? CfDesc { get; set; }

    public string? CfPartyCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public double? ProvisionalPayable { get; set; }

    public double? ActualPayable { get; set; }

    public string? Keys { get; set; }
}
