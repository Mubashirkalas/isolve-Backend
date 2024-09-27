using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemConsRate1
{
    public string? TrItemno { get; set; }

    public DateOnly? Gdate { get; set; }

    public string? MGrncons { get; set; }

    public decimal Trrate { get; set; }
}
