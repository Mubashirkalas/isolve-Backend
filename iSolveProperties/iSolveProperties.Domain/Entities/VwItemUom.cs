using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemUom
{
    public string ItemCode { get; set; } = null!;

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public string? ItDesc { get; set; }

    public string ItemGroup { get; set; } = null!;

    public byte CompId { get; set; }

    public string? BarCode { get; set; }

    public string? ItemStatus { get; set; }

    public string? ItemDescription { get; set; }

    public int WholeSaleRate { get; set; }

    public double? Rate { get; set; }

    public double? OldRate { get; set; }

    public double? MarketRate { get; set; }

    public string? BarCodeTwo { get; set; }

    public bool? IsPrimary { get; set; }
}
