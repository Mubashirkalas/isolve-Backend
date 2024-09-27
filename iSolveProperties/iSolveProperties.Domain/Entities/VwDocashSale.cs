using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDocashSale
{
    public byte? Sno { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Capacity { get; set; }

    public int? Quantity { get; set; }

    public double? UnitRate { get; set; }

    public double? Value { get; set; }

    public string FYear { get; set; } = null!;

    public byte CompId { get; set; }

    public string Srno { get; set; } = null!;

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }
}
