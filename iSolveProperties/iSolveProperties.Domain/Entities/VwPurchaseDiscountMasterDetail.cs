using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPurchaseDiscountMasterDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? PdNo { get; set; }

    public short? Sno { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Discount { get; set; }

    public byte Expr1 { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
