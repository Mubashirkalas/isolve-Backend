using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWDecantingDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? Sno { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public int? DecantingNo { get; set; }

    public string? Igpno { get; set; }

    public string? Igpdate { get; set; }

    public string? Pono { get; set; }

    public string? Podate { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public byte? SubSegmentIdIgp { get; set; }

    public string? SubSegmentName { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? Uom { get; set; }

    public double? IssueQty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public double? SalesTax { get; set; }

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }

    public string? Dcno { get; set; }

    public string? Dcdate { get; set; }

    public double? GrossWeight { get; set; }

    public double? TareWeight { get; set; }

    public double? NetWeight { get; set; }

    public byte? WarehouseNo { get; set; }

    public string? Whname { get; set; }
}
