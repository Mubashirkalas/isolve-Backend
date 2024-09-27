using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PipePurchaseDetail
{
    public int? SNo { get; set; }

    public string SMainkey { get; set; } = null!;

    public DateTime? SDate { get; set; }

    public string CompId { get; set; } = null!;

    public string? SCount { get; set; }

    public double? SQtyBags { get; set; }

    public int SSerial { get; set; }

    public double? SSaleRate { get; set; }

    public double? SSaleValue { get; set; }

    public double? SSalesTaxValue { get; set; }

    public double? SIncValue { get; set; }

    public double? SAvgRate { get; set; }

    public double? SAvgValue { get; set; }

    public int? SPipes { get; set; }

    public string? SUnit { get; set; }

    public double? SSfed { get; set; }
}
