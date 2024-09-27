using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemPurchaseRate1
{
    public string? TrItemno { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? MGrn { get; set; }

    public decimal? Rate { get; set; }

    public string? PrtyName { get; set; }

    public decimal ItCbal { get; set; }
}
