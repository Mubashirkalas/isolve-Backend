using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vweditlistingall
{
    public DateOnly? Grndate { get; set; }

    public string Grnno { get; set; } = null!;

    public string? Type { get; set; }

    public string Year { get; set; } = null!;

    public decimal? TrQty { get; set; }

    public decimal? TrAccept { get; set; }

    public decimal? TrValue { get; set; }

    public string? TrItemno { get; set; }

    public int CompId { get; set; }

    public string? ItDesc { get; set; }

    public string? PrtyName { get; set; }
}
