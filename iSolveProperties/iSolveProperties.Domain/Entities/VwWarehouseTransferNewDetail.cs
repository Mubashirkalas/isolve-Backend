using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwWarehouseTransferNewDetail
{
    public short? Sno { get; set; }

    public string? WhnameFrom { get; set; }

    public string? WhnameTo { get; set; }

    public string? RequisitionNo { get; set; }

    public DateOnly? RequiredDate { get; set; }

    public string? RequisitionKey { get; set; }

    public int? RequisitionDetailSno { get; set; }

    public string? GroupName { get; set; }

    public string? ItemName { get; set; }

    public string? BatchNo { get; set; }

    public string? BatchNumber { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public byte? WhnoFrom { get; set; }

    public byte? WhnoTo { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? CurrentQty { get; set; }

    public double? RequiredQty { get; set; }

    public double? TotalIssueQty { get; set; }

    public double? IssueQty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public string? ItemSerialNo { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public string? WarehouseFromSubSegmentId { get; set; }

    public string? WarehouseToSubSegmentId { get; set; }

    public string WhtransferKey { get; set; } = null!;

    public byte? RequisitionSubSegmentId { get; set; }
}
