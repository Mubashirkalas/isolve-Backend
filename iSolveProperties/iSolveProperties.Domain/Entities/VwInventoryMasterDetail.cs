using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInventoryMasterDetail
{
    public string? Uom { get; set; }

    public string? BatchNo { get; set; }

    public DateOnly? ExpiryDate { get; set; }

    public int? Srno { get; set; }

    public double? PurchaseQty { get; set; }

    public DateOnly? Grndate { get; set; }

    public int? Grnno { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Type { get; set; }

    public string? ItemName { get; set; }

    public string? Whname { get; set; }

    public double? IssueQty { get; set; }

    public byte? ToWareHouseNo { get; set; }

    public string Keys { get; set; } = null!;

    public DateOnly? GrnDate1 { get; set; }

    public string Year { get; set; } = null!;

    public short? SubSegmentId { get; set; }
}
