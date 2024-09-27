using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwGrnrate
{
    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public decimal? Rate { get; set; }

    public byte CompId { get; set; }

    public double? IssueQty { get; set; }
}
