using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDowarehouse
{
    public byte? Sno { get; set; }

    public byte? FWarehouseCode { get; set; }

    public string? FWarehouseName { get; set; }

    public byte? FWarehouseSubSegmentCode { get; set; }

    public string? FWarehouseSubSegmentName { get; set; }

    public byte? TWarehouseCode { get; set; }

    public string? TWarehouseName { get; set; }

    public byte? TWarehouseSubSegmentCode { get; set; }

    public string? TWarehouseSubSegmentName { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public int? CylindersQty { get; set; }

    public double? M3Qty { get; set; }

    public double? KgQty { get; set; }

    public double? LtrQty { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public string? JoNo { get; set; }

    public string? JoDate { get; set; }
}
