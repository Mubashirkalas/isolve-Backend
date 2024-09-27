using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DeliveryOrderWarehouse
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? DoNo { get; set; }

    public byte? Sno { get; set; }

    public string? JoNo { get; set; }

    public DateOnly? JoDate { get; set; }

    public byte? FWarehouseCode { get; set; }

    public byte? FWarehouseSubSegmentCode { get; set; }

    public byte? TWarehouseCode { get; set; }

    public byte? TWarehouseSubSegmentCode { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public int? CylindersQty { get; set; }

    public double? M3Qty { get; set; }

    public double? KgQty { get; set; }

    public double? LtrQty { get; set; }

    public virtual DeliveryOrderMaster? DeliveryOrderMaster { get; set; }
}
