using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class JobOrderWarehouse
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? JobOrderNo { get; set; }

    public byte? Sno { get; set; }

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

    public string? Status { get; set; }

    public virtual JobOrderMaster JobOrderMaster { get; set; } = null!;
}
