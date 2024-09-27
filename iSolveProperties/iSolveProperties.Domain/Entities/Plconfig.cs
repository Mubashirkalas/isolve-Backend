using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Plconfig
{
    public int PlineNo { get; set; }

    public string? Pheading { get; set; }

    public string? Pnote { get; set; }

    public string? Main { get; set; }

    public bool Pfig { get; set; }

    public string PlCode { get; set; } = null!;

    public bool Pupline { get; set; }

    public bool Pbox { get; set; }

    public bool Pdownline { get; set; }

    public bool Headingbold { get; set; }

    public bool Figurbold { get; set; }

    public bool Pdbunderline { get; set; }

    public int? ListIndex { get; set; }
}
