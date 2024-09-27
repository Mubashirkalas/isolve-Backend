using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQuotaFile
{
    public string? Bpname { get; set; }

    public int? FileNo { get; set; }

    public bool? FormNo { get; set; }

    public string? AreaName { get; set; }

    public double? Amount { get; set; }

    public int? OwnAmount { get; set; }

    public int? Discount { get; set; }

    public string? DealName { get; set; }

    public string? Status { get; set; }

    public string? Bpcode { get; set; }
}
