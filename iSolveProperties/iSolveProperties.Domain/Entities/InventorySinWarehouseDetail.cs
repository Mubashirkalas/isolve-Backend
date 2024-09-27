using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InventorySinWarehouseDetail
{
    public short? Sno { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? Uom { get; set; }

    public byte? FromWarehouseNo { get; set; }

    public byte? FromWarehouseSubsegmentId { get; set; }

    public byte? ToWareHouseNo { get; set; }

    public byte? ToWareHouseSubSegmentId { get; set; }

    public double? QtyInStock { get; set; }

    public double? TransferedQty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? TransportationCharges { get; set; }

    public double TotalValue { get; set; }

    public string? Type { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }
}
