using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DepreciationDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short? Sno { get; set; }

    public string? LocationId { get; set; }

    public double? DepreciationAmount { get; set; }

    public string? Keys { get; set; }

    public virtual Depreciation Depreciation { get; set; } = null!;
}
