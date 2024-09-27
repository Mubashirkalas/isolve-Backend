using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMchitemWisSum
{
    public string? TrMch { get; set; }

    public string? MchDesc { get; set; }

    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? Value { get; set; }
}
