using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMainStoreOpeningall
{
    public string? Mainstore { get; set; }

    public decimal? Opening { get; set; }

    public decimal? Opvalue { get; set; }

    public int CompId { get; set; }
}
