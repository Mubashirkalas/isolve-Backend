using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PurchaseDiscountDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? PdNo { get; set; }

    public short? Sno { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Discount { get; set; }

    public virtual PurchaseDiscountMain? PurchaseDiscountMain { get; set; }
}
