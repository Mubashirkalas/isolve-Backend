using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectReversal
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short SubSegmentId { get; set; }

    public int SerialNo { get; set; }

    public int ProjectSrno { get; set; }

    public DateOnly Date { get; set; }

    public string Reason { get; set; } = null!;

    public virtual ProjectSale ProjectSale { get; set; } = null!;

    public virtual SubSegment SubSegment { get; set; } = null!;
}
