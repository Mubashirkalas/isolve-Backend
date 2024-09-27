using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCurrentItemRate
{
    public string? ItCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public decimal? OpeningRate { get; set; }

    public string? LastGrnno { get; set; }

    public decimal? LastGrnrate { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? PrtyName { get; set; }

    public decimal? ItCbal { get; set; }

    public decimal? Qqty { get; set; }
}
