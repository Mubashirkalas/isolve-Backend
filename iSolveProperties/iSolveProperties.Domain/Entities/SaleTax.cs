using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SaleTax
{
    public int? SInvno { get; set; }

    public DateTime? SDate { get; set; }

    public string? SBuyer { get; set; }

    public double? SStper { get; set; }

    public string? SOrderNo { get; set; }

    public DateTime? SOrderDate { get; set; }

    public string? SInvsub { get; set; }

    public string? SType { get; set; }

    public double? SQtyBags { get; set; }

    public string? Expr1 { get; set; }

    public double? SSaleRate { get; set; }

    public double? SSaleValue { get; set; }

    public double? SSalesTaxValue { get; set; }

    public double? SIncValue { get; set; }

    public int? SPipes { get; set; }

    public string? SUnit { get; set; }

    public double? SSfed { get; set; }

    public string GlCode { get; set; } = null!;

    public string? AdAddress1 { get; set; }

    public string? AdStreg { get; set; }

    public string? Bname { get; set; }

    public int SSerial { get; set; }
}
