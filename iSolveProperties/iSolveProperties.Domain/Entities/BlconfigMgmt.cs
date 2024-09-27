using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BlconfigMgmt
{
    public string Blineno { get; set; } = null!;

    public string? Lhead { get; set; }

    public bool Lfig { get; set; }

    public string? Lnote { get; set; }

    public string? Lndc { get; set; }

    public bool Luline { get; set; }

    public bool Lbox { get; set; }

    public bool Ldline { get; set; }

    public string? Lcode1 { get; set; }

    public string? Lcode2 { get; set; }

    public string? Lcode3 { get; set; }

    public string? Lcode4 { get; set; }

    public bool Lduline { get; set; }

    public string? Lmain { get; set; }

    public bool LfboLd { get; set; }

    public bool Lhbold { get; set; }

    public string? Rhead { get; set; }

    public bool Rfig { get; set; }

    public string? Rnote { get; set; }

    public string? Rndc { get; set; }

    public bool Ruline { get; set; }

    public bool Rdline { get; set; }

    public bool Rbox { get; set; }

    public string? Rcode1 { get; set; }

    public string? Rcode2 { get; set; }

    public string? Rcode3 { get; set; }

    public string? Rcode4 { get; set; }

    public bool Rduline { get; set; }

    public string? Rmain { get; set; }

    public bool Rfbold { get; set; }

    public bool Rhbold { get; set; }

    public string? Lcodestatus { get; set; }

    public string? Rcodestatus { get; set; }
}
