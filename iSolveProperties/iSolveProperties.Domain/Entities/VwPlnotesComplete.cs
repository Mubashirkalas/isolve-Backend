using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPlnotesComplete
{
    public string? Note { get; set; }

    public string? Heading { get; set; }

    public string? GlCode { get; set; }

    public string? GlDesc { get; set; }

    public double? NetAmount { get; set; }
}
