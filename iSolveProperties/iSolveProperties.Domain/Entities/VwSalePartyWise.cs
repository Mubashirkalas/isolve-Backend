using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalePartyWise
{
    public string? GlCode { get; set; }

    public string GlDesc { get; set; } = null!;

    public string? Narration { get; set; }

    public double? Amount { get; set; }

    public DateOnly? VDate { get; set; }

    public double? Qty1 { get; set; }

    public string? Unit1 { get; set; }

    public string? VInvNo { get; set; }

    public double? Qty2 { get; set; }

    public string? Unit2 { get; set; }

    public string VKey { get; set; } = null!;

    public string? Itemcode { get; set; }

    public string Itemdesc { get; set; } = null!;
}
