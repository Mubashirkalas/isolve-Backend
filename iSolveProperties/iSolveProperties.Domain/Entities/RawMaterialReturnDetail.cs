using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class RawMaterialReturnDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short? Sno { get; set; }

    public byte? WhnoFrom { get; set; }

    public byte? WhnoTo { get; set; }

    public int? RequisitionNo { get; set; }

    public DateOnly? RequiredDate { get; set; }

    public string? RequisitionKey { get; set; }

    public byte? RequisitionSubSegmentId { get; set; }

    public int? RequisitionDetailSno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? CurrentQty { get; set; }

    public double? IssuedQty { get; set; }

    public double? ReturnQty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public string? ItemSerialNo { get; set; }

    public double? RemQty { get; set; }

    public string? Remarks { get; set; }

    public string? Status { get; set; }

    public string? WarehouseFromSubSegmentId { get; set; }

    public string? WarehouseToSubSegmentId { get; set; }

    public string WhtransferKey { get; set; } = null!;

    public virtual ItemMaster? ItemMaster { get; set; }

    public virtual RawMaterialReturnMaster RawMaterialReturnMaster { get; set; } = null!;
}
