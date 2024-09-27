using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwtestGrn
{
    public string? Grnno { get; set; }

    public string? Type { get; set; }

    public string? GrnDate { get; set; }

    public string Keys { get; set; } = null!;

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? Srno { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? BpCode { get; set; }

    public byte? SubSegmentCode { get; set; }

    public double? PurchaseQty { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }

    public string? Igpno { get; set; }

    public string? IgpDate { get; set; }

    public string? Pono { get; set; }

    public string? PoDate { get; set; }

    public string? Dcno { get; set; }

    public string? DcDate { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public byte? WarehouseNo { get; set; }

    public short? Sno { get; set; }

    public string? CreationDate { get; set; }

    public DateTime? TrCreationDate { get; set; }

    public double RemainingValue { get; set; }

    public double RemainingRate { get; set; }

    public double RemainingQty { get; set; }

    public DateOnly? Grndate1 { get; set; }

    public string? GrnVoucherKey { get; set; }
}
