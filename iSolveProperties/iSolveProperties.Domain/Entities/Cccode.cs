using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Cccode
{
    public string CcCode1 { get; set; } = null!;

    public string? CcDesc { get; set; }

    public decimal? CcBudget { get; set; }

    public string? CcNotes { get; set; }

    public string? SUser { get; set; }

    public DateTime? OpDate { get; set; }

    public int? CompId { get; set; }
}
