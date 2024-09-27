using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSaleWithCg
{
    public int? Qty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public int ReturnQty { get; set; }

    public double ReturnValue { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public double? CgsRate { get; set; }

    public DateOnly? SalesDate { get; set; }

    public short? Userid { get; set; }

    public string? UserName { get; set; }

    public byte? SubsegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;
}
