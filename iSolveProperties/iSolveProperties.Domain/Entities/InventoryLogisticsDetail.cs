using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InventoryLogisticsDetail
{
    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string DriverId { get; set; } = null!;

    public double? RemainingQy { get; set; }

    public double? IssueQty { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public string? Type { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public string? VehicleRegistration { get; set; }

    public byte? WarehouseSubsegmentId { get; set; }

    public double? TransportationCharges { get; set; }

    public double? TotalValue { get; set; }

    public byte? WarehouseNo { get; set; }
}
