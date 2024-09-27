using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwrptPiop
{
    public decimal? Bal { get; set; }

    public string ItCode { get; set; } = null!;

    public int CompId { get; set; }

    public string Openingyear { get; set; } = null!;
}
