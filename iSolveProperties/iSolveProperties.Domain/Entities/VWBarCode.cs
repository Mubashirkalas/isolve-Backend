using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWBarCode
{
    public string? ItemGroup { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? BarCode { get; set; }

    public double? Rate { get; set; }

    public int? SerialNo { get; set; }
}
