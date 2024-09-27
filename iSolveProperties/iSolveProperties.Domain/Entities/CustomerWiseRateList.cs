using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CustomerWiseRateList
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public DateOnly? ApplicableDate { get; set; }

    public string? PartyType { get; set; }

    public string? RateType { get; set; }
}
