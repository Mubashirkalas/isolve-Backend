using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCustomerRateList
{
    public string Bpcode { get; set; } = null!;

    public byte? CompId { get; set; }

    public string? RateType { get; set; }

    public string? Bpname { get; set; }
}
