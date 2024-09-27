using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemFinalQty
{
    public double OpeningQty { get; set; }

    public decimal OpeningValue { get; set; }

    public double PurchasedQtyProducedQty { get; set; }

    public double IssueQty { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? Uom { get; set; }

    public short? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public short? Whno { get; set; }

    public string? Whname { get; set; }

    public string? BatchNo { get; set; }

    public DateOnly? ExpiryDate { get; set; }
}
