using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwVendorCommission
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Bpcode { get; set; }

    public DateOnly? ApplicableDate { get; set; }

    public string? PlanName { get; set; }

    public string? Bpname { get; set; }
}
