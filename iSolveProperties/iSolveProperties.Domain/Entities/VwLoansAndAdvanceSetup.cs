using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLoansAndAdvanceSetup
{
    public byte CompId { get; set; }

    public string SrNo { get; set; } = null!;

    public string Year { get; set; } = null!;

    public string? GlCode { get; set; }

    public string? Title { get; set; }

    public string GlDesc { get; set; } = null!;
}
