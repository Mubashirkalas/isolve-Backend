using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalemenSale
{
    public string? SBuyer { get; set; }

    public string? Bname { get; set; }

    public string SYear { get; set; } = null!;

    public string? SOrderNo { get; set; }

    public DateTime? SOrderDate { get; set; }

    public int? SChallanNo { get; set; }

    public double? SSaleRate { get; set; }

    public double? SSaleValue { get; set; }

    public double? SQtyBags { get; set; }
}
