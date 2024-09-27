using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemRunningQty
{
    public double PurchasedQtyProducedQty { get; set; }

    public double IssueQty { get; set; }

    public decimal PurchaseValueProducedValue { get; set; }

    public decimal IssueValue { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? Uom { get; set; }

    public byte? CompId { get; set; }

    public short? WarehouseNo { get; set; }

    public short? SubSegmentIdMain { get; set; }

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public string? Whname { get; set; }

    public string? SubSegmentName { get; set; }

    public string? BatchNo { get; set; }

    public DateOnly? ExpiryDate { get; set; }
}
