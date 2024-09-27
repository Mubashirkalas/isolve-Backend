using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VendorItemsDetail
{
    public string? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public int? SNo { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }
}
