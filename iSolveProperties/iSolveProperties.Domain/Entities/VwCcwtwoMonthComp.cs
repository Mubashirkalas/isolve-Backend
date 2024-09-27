using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCcwtwoMonthComp
{
    public int Npmetrial { get; set; }

    public string? TrCc { get; set; }

    public string? CcDesc { get; set; }

    public decimal PMonthC { get; set; }

    public decimal PMonthP { get; set; }

    public decimal CMonthC { get; set; }

    public decimal CMonthP { get; set; }

    public decimal ToDateC { get; set; }

    public decimal ToDateP { get; set; }

    public decimal? AvgC { get; set; }

    public decimal? AvgP { get; set; }
}
