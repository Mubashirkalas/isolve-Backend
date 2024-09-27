using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class StockAdjustmentDetail
{
    public string? Srno { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? Uom { get; set; }

    public byte? WareHouseNo { get; set; }

    public double? QtyInStock { get; set; }

    public string? Reason { get; set; }

    public double? AddQty { get; set; }

    public double? DeductedQty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public virtual StockAdustmentMaster? StockAdustmentMaster { get; set; }
}
