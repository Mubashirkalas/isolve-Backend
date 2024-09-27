using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTeamSetupMainDetail
{
    public string? MemberCode { get; set; }

    public string SerialNo { get; set; } = null!;

    public string? Bpcode { get; set; }

    public double? Commission { get; set; }

    public byte CompId { get; set; }

    public DateOnly? ApplicableDate { get; set; }

    public string? Bpname { get; set; }

    public double? CommissionValue { get; set; }

    public string? Project { get; set; }
}
