using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwregister
{
    public DateOnly? Grndate { get; set; }

    public string? ItDesc { get; set; }

    public string? Grnno { get; set; }

    public string? PrtyName { get; set; }

    public string? CcDesc { get; set; }

    public string? TrItemno { get; set; }

    public string? ItUnit { get; set; }

    public decimal? Qty { get; set; }

    public decimal? Value { get; set; }

    public string? Type { get; set; }

    public string? Abbr { get; set; }

    public decimal? Receipt { get; set; }

    public decimal? ReceiptV { get; set; }

    public decimal Issue { get; set; }

    public decimal Issuev { get; set; }
}
