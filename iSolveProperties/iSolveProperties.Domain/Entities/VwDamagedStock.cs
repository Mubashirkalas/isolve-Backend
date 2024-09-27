using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDamagedStock
{
    public string? FromWarehouseName { get; set; }

    public string? ToWarehouseName { get; set; }

    public string? GroupName { get; set; }

    public string? ItemName { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public string? FromSubSegmentId { get; set; }

    public string? ToSubSegmentId { get; set; }

    public string FromSubSegmentName { get; set; } = null!;

    public string ToSubSegmentName { get; set; } = null!;

    public byte? FromWarehouse { get; set; }

    public byte? ToWarehouse { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }
}
