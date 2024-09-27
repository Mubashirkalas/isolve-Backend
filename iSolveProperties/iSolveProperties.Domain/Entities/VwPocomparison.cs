using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPocomparison
{
    public string? Bpcode { get; set; }

    public decimal? NetPurchaseRate { get; set; }

    public DateOnly? PoDate { get; set; }

    public byte? CompId { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? PoNo { get; set; }
}
