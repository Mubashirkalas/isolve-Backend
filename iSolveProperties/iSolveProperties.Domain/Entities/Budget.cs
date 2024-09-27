using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Budget
{
    public string GlCode { get; set; } = null!;

    public int DId { get; set; }

    public string FinYear { get; set; } = null!;

    public decimal? Amount { get; set; }

    public int CompId { get; set; }
}
