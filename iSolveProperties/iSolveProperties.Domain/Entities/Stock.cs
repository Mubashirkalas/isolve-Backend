using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Stock
{
    public decimal? PurchaseQty { get; set; }

    public decimal? IssueQty { get; set; }

    public decimal? PurchaseValue { get; set; }

    public decimal? IssueValue { get; set; }

    public double? Reorder { get; set; }

    public short? SubSegment { get; set; }

    public string? SubSegmentName { get; set; }

    public short? Warehouse { get; set; }

    public string? WarehouseName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public byte? CompId { get; set; }
}
