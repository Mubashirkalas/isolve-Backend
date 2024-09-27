using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TaxSlab
{
    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public int? Sno { get; set; }

    public double? RangeStart { get; set; }

    public double? RangeEnd { get; set; }

    public double? MinTax { get; set; }

    public double? Percentage { get; set; }
}
