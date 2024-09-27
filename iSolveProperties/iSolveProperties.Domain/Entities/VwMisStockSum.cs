using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMisStockSum
{
    public string? Main { get; set; }

    public decimal? Opvalue { get; set; }

    public decimal? Receipt { get; set; }

    public decimal? Consumpumtion { get; set; }

    public decimal? Capitalized { get; set; }

    public decimal? Issue { get; set; }

    public decimal? Sale { get; set; }

    public int? CompId { get; set; }
}
