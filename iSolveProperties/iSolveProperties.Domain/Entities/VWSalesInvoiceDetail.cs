using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWSalesInvoiceDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public int? Qty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public string? BarCode { get; set; }

    public double? TotalValue { get; set; }

    public double? Discount { get; set; }

    public double? CgsRate { get; set; }

    public DateOnly? SalesDate { get; set; }

    public short? Userid { get; set; }

    public string? UserName { get; set; }

    public string? UserLogin { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte? SubsegmentId { get; set; }
}
