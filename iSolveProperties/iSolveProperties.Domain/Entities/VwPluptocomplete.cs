using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPluptocomplete
{
    public decimal? PlineNo { get; set; }

    public string? Pheading { get; set; }

    public string? Pnote { get; set; }

    public string PlCode { get; set; } = null!;

    public double Amount { get; set; }

    public bool Pupline { get; set; }

    public bool Pdownline { get; set; }

    public bool Pdbunderline { get; set; }

    public bool Pbox { get; set; }

    public bool Pfig { get; set; }

    public bool Figurbold { get; set; }

    public bool Headingbold { get; set; }
}
