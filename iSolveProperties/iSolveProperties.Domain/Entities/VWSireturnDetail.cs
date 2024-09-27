using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWSireturnDetail
{
    public short? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? BarCode { get; set; }

    public string? Uom { get; set; }

    public int? Qty { get; set; }

    public double? Rate { get; set; }

    public double? Value { get; set; }

    public int? ReturnQty { get; set; }

    public double? ReturnValue { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }
}
