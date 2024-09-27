using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMisDailyStsum
{
    public string? Mainstore { get; set; }

    public decimal? Opening { get; set; }

    public decimal? Opvalue { get; set; }

    public decimal? Receipt { get; set; }

    public decimal? Issue { get; set; }
}
