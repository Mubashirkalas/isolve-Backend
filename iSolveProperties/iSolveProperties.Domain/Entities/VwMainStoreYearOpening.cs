using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMainStoreYearOpening
{
    public string? Mainstore { get; set; }

    public decimal? Opqty { get; set; }

    public decimal? Opvalue { get; set; }

    public int CompId { get; set; }
}
