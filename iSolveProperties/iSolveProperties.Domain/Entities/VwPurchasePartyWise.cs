using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPurchasePartyWise
{
    public string? GlCode { get; set; }

    public string GlDesc { get; set; } = null!;

    public string? Narration { get; set; }

    public double? Amount { get; set; }

    public DateOnly? Vdate { get; set; }

    public double? Qty1 { get; set; }

    public string? Unit1 { get; set; }

    public string? Invno { get; set; }

    public double? Qty2 { get; set; }

    public string? Unit2 { get; set; }

    public string Vkey { get; set; } = null!;
}
