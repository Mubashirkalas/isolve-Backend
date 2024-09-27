using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemRate
{
    public string Code { get; set; } = null!;

    public string? Desc { get; set; }

    public string? Unit { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Value { get; set; }

    public decimal? Rate { get; set; }
}
