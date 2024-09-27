using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDealerQuotaDetail
{
    public string? PropertyDescription { get; set; }

    public string? BlockName { get; set; }

    public string? AreaName { get; set; }

    public string? PropertyDetailsTitle { get; set; }

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public short Sno { get; set; }

    public string Pid { get; set; } = null!;

    public int Amount { get; set; }

    public string? Status { get; set; }
}
