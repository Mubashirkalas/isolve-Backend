using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Po
{
    public short? Srno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public double? PoQtyord { get; set; }

    public double? PoRate { get; set; }

    public double? PoValue { get; set; }

    public string? RequisitionNo { get; set; }

    public string? Keys { get; set; }

    public string? Year { get; set; }

    public string? PoNo { get; set; }

    public byte? CompId { get; set; }

    public DateOnly? RequisitionDate { get; set; }

    public double? BalanceQty { get; set; }

    public string? Uom { get; set; }

    public string? Status { get; set; }

    public byte? SubSegmentId { get; set; }

    public double? Stax { get; set; }

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }
}
