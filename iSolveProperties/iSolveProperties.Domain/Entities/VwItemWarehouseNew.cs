using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemWarehouseNew
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

    public short? Whno { get; set; }

    public string? Whname { get; set; }

    public string? Sku { get; set; }

    public bool? IsPrimary { get; set; }
}
