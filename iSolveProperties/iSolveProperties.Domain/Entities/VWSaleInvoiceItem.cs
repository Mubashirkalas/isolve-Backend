using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWSaleInvoiceItem
{
    public string? GroupCode { get; set; }

    public string? GroupName { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? Rate { get; set; }

    public string? BarCode { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }
}
