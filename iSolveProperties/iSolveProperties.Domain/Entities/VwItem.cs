using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItem
{
    public double? OpeningQty { get; set; }

    public decimal? OpeningValue { get; set; }

    public string ItCode { get; set; } = null!;

    public short? SubSegmentId { get; set; }

    public byte CompId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Whname { get; set; }

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public string? Uom { get; set; }

    public string ItemCode { get; set; } = null!;

    public short? WarehouseNo { get; set; }
}
