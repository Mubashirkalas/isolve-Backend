using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LcfacilityDetail
{
    public byte Srno { get; set; }

    public string AccountNumber { get; set; } = null!;

    public byte CompId { get; set; }

    public string? FacilityNo { get; set; }

    public string? FacilityName { get; set; }

    public double? FacilityAmount { get; set; }

    public double? InterestRate { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public short? SrNo1 { get; set; }

    public virtual LcfacilityMain LcfacilityMain { get; set; } = null!;
}
