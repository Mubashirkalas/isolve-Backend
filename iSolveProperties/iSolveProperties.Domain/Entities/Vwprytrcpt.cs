using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwprytrcpt
{
    public string? Party { get; set; }

    public string? PrtyName { get; set; }

    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Value { get; set; }

    public decimal? TrStax { get; set; }
}
