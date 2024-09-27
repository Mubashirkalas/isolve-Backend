using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwStockIssueDetail
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Available { get; set; }

    public double? Qty { get; set; }

    public DateOnly? Date { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public short? SubProjectId { get; set; }

    public short? SubSegmentId { get; set; }
}
