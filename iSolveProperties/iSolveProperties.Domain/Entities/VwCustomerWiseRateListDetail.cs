using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCustomerWiseRateListDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public int? Sno { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public string? ItemName { get; set; }

    public string? GroupName { get; set; }

    public byte CompId1 { get; set; }
}
