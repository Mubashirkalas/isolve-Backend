using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VuDoReport
{
    public int SNo { get; set; }

    public DateTime? SDate { get; set; }

    public int? SInvno { get; set; }

    public DateTime? SInvdate { get; set; }

    public string? SBuyer { get; set; }

    public string? Buyer { get; set; }

    public string SYear { get; set; } = null!;

    public double? SStper { get; set; }

    public string? SOrderNo { get; set; }

    public DateTime? SOrderDate { get; set; }

    public string? SRefNo { get; set; }

    public DateTime? SRefDate { get; set; }

    public string? SVehicle { get; set; }

    public string? SBilty { get; set; }

    public string? SDriver { get; set; }

    public string? SCount { get; set; }

    public string? Item { get; set; }

    public double? SQtyBags { get; set; }

    public int SSerial { get; set; }

    public string? SSaleRate { get; set; }

    public double? SSaleValue { get; set; }

    public double? SSalesTaxValue { get; set; }

    public double? SIncValue { get; set; }

    public double? SAvgRate { get; set; }

    public double? SAvgValue { get; set; }

    public int? SPipes { get; set; }

    public string? SUnit { get; set; }

    public double? SSfed { get; set; }
}
