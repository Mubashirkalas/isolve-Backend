using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwMasterNew
{
    public string Keyfield { get; set; } = null!;

    public string Grnno { get; set; } = null!;

    public string? Type { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Gpno { get; set; }

    public DateOnly? Gpdate { get; set; }

    public string? Billno { get; set; }

    public string? Ref { get; set; }

    public string? Lot { get; set; }

    public string? PrtyName { get; set; }

    public string? Party { get; set; }

    public int CompId { get; set; }

    public string? Abbr { get; set; }
}
