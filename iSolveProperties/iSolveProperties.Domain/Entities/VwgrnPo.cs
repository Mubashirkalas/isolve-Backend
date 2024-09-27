using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwgrnPo
{
    public string? Grnno { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? TrItemno { get; set; }

    public decimal? TrQty { get; set; }

    public decimal? TrAccept { get; set; }

    public decimal? TrValue { get; set; }

    public double? Pono { get; set; }

    public DateOnly? Podate { get; set; }

    public double? Reqno { get; set; }

    public DateOnly? Reqdate { get; set; }

    public string? Uom { get; set; }

    public string? Supliercode { get; set; }

    public double? Rate { get; set; }

    public string? Name { get; set; }

    public string? ItDesc { get; set; }

    public string? Type { get; set; }
}
