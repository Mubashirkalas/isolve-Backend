using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LoanAndAdvanceSetup
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Title { get; set; }

    public string? Type { get; set; }

    public string? Glcode { get; set; }

    public virtual ICollection<LoanAndAdvance> LoanAndAdvances { get; set; } = new List<LoanAndAdvance>();
}
