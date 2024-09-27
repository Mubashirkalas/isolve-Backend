using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Table2
{
    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public decimal? Qty { get; set; }

    public byte? SubSegment { get; set; }

    public byte? Warehouse { get; set; }
}
