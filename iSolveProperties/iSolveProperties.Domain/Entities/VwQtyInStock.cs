using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwQtyInStock
{
    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? Uom { get; set; }

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? WarehouseNo { get; set; }

    public double RemainingQty { get; set; }

    public double RemainingRate { get; set; }

    public double RemainingValue { get; set; }

    public string? Srno { get; set; }

    public byte? SubSegmentId { get; set; }

    public short? Sno { get; set; }

    public double? SerialNo { get; set; }
}
