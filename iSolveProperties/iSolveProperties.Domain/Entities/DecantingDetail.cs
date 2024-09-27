using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DecantingDetail
{
    public int? Sno { get; set; }

    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public int? DecantingNo { get; set; }

    public string? Igpno { get; set; }

    public DateOnly? Igpdate { get; set; }

    public string? Pono { get; set; }

    public DateOnly? Podate { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public byte? SubSegmentIdIgp { get; set; }

    public string? BpCode { get; set; }

    public string? Uom { get; set; }

    public double? IssueQty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }

    public string? Dcno { get; set; }

    public DateOnly? Dcdate { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public byte? WarehouseNo { get; set; }

    public virtual DecantingMain? DecantingMain { get; set; }
}
