using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRawMaterialReturnMaster
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Type { get; set; }

    public string? VehicleNo { get; set; }

    public string? DriverName { get; set; }

    public string? DriverPhoneNo { get; set; }

    public double? TransportationCharges { get; set; }

    public double? OtherOverheads { get; set; }

    public string? WarehouseFrom { get; set; }

    public string? WarehouseTo { get; set; }

    public string? Status { get; set; }

    public string? Keys { get; set; }

    public string? WarehouseFromSubSegmentId { get; set; }

    public string? WarehouseToSubSegmentId { get; set; }

    public string? DepartmentId { get; set; }

    public string? IssuanceNo { get; set; }

    public string? IssuanceSrno { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? WarehouseFromName { get; set; }

    public string? WarehouseToName { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? DepartmentName { get; set; }
}
