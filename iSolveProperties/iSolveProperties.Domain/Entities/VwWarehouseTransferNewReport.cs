using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwWarehouseTransferNewReport
{
    public short? Sno { get; set; }

    public string? WhnameFrom { get; set; }

    public string? WhnameTo { get; set; }

    public string? GroupName { get; set; }

    public string? ItemName { get; set; }

    public string? RequisitionNo { get; set; }

    public DateOnly? RequiredDate { get; set; }

    public string? RequisitionKey { get; set; }

    public int? RequisitionDetailSno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? CurrentQty { get; set; }

    public double? RequiredQty { get; set; }

    public double? IssueQty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public string? ItemSerialNo { get; set; }

    public double? RemQty { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public string WhtransferKey { get; set; } = null!;

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? VehicleNo { get; set; }

    public string? DriverName { get; set; }

    public string? DriverPhoneNo { get; set; }

    public double? TransportationCharges { get; set; }

    public double? OtherOverheads { get; set; }

    public string? Keys { get; set; }

    public string? DepartmentId { get; set; }

    public string? WarehouseToSubSegmentId { get; set; }

    public string? WarehouseFromSubSegmentId { get; set; }

    public string? WarehouseTo { get; set; }

    public string? WarehouseFrom { get; set; }

    public string FromSubSegmentName { get; set; } = null!;

    public string ToSubSegmentName { get; set; } = null!;

    public string? DepartmentName { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyAddress { get; set; }

    public string? BatchNo { get; set; }

    public byte? WhnoFrom { get; set; }

    public byte? WhnoTo { get; set; }
}
