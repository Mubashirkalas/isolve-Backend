using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSale
{
    public int SNo { get; set; }

    public string SMainKey { get; set; } = null!;

    public DateTime? SDate { get; set; }

    public int? SInvno { get; set; }

    public DateTime? SInvdate { get; set; }

    public string? SType { get; set; }

    public int? SOwgpNo { get; set; }

    public string? SBuyer { get; set; }

    public string SYear { get; set; } = null!;

    public DateTime? SOwgpDate { get; set; }

    public string? SSupplier { get; set; }

    public double? SStper { get; set; }

    public string? SAccountskey { get; set; }

    public string? SOrderNo { get; set; }

    public DateTime? SOrderDate { get; set; }

    public int? SChallanNo { get; set; }

    public string? SInvsub { get; set; }

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

    public string GlDesc { get; set; } = null!;

    public string Expr1 { get; set; } = null!;
}
