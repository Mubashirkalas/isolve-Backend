using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwVendorItemsDetail
{
    public string? SerialNo { get; set; }

    public string? ItemGroup { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? ItDesc { get; set; }

    public int? SNo { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public string? BpCode { get; set; }

    public byte? CompId { get; set; }

    public string? BusinessPartnersName { get; set; }
}
