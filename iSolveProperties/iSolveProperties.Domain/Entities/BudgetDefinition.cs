using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BudgetDefinition
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public DateOnly? Date { get; set; }

    public short? SubSegmentId { get; set; }

    public string? Type { get; set; }

    public string? Levels { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual SubSegment? SubSegment { get; set; }
}
