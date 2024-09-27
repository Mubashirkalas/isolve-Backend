using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBsnotesComplete
{
    public string? Note { get; set; }

    public string? Heading { get; set; }

    public string GlCode { get; set; } = null!;

    public string GlDesc { get; set; } = null!;

    public double Netamount { get; set; }
}
