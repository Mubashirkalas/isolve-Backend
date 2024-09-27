using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BalanceSheetConfiguration
{
    public int Line { get; set; }

    public string HeadingL { get; set; } = null!;

    public string? NoteL { get; set; }

    public string NetdrcrL { get; set; } = null!;

    public string PrintfigureL { get; set; } = null!;

    public string? Bs1L { get; set; }

    public string? Bs2L { get; set; }

    public string? Bs3L { get; set; }

    public string? Bs4L { get; set; }

    public string? Bs5L { get; set; }

    public string UplineL { get; set; } = null!;

    public string BoxL { get; set; } = null!;

    public string DownlineL { get; set; } = null!;

    public string HeadingboldL { get; set; } = null!;

    public string FigureboldL { get; set; } = null!;

    public string? DoubleunderlineL { get; set; }

    public string HeadingR { get; set; } = null!;

    public string? NoteR { get; set; }

    public string NetdrcrR { get; set; } = null!;

    public string PrintfigureR { get; set; } = null!;

    public string? Bs1R { get; set; }

    public string? Bs2R { get; set; }

    public string? Bs3R { get; set; }

    public string? Bs4R { get; set; }

    public string? Bs5R { get; set; }

    public string UplineR { get; set; } = null!;

    public string BoxR { get; set; } = null!;

    public string DownlineR { get; set; } = null!;

    public string HeadingboldR { get; set; } = null!;

    public string FigureboldR { get; set; } = null!;

    public string DoubleunderlineR { get; set; } = null!;
}
