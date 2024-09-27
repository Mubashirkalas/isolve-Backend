using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWSalesMonthly
{
    public int SNo { get; set; }

    public string SBuyer { get; set; } = null!;

    public string? SInvno { get; set; }

    public DateOnly? SOrderDate { get; set; }

    public string? SOrderNo { get; set; }

    public DateOnly? SDate { get; set; }

    public string? SStper { get; set; }

    public int? SNo1 { get; set; }

    public string? SUnit { get; set; }

    public int? SQtyBags { get; set; }

    public double? SSaleRate { get; set; }

    public double? SSaleValue { get; set; }

    public double? SSalesTaxValue { get; set; }

    public double? SAvgValue { get; set; }

    public string? SCount { get; set; }

    public string? SDesc { get; set; }
}
