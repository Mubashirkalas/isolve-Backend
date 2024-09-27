using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectReschedule
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short SubSegmentId { get; set; }

    public int SerialNo { get; set; }

    public int ProjectSrno { get; set; }

    public DateOnly Date { get; set; }

    public string Reason { get; set; } = null!;

    public short SuserId { get; set; }

    public string SuserName { get; set; } = null!;

    public string SworkStation { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual ProjectSale ProjectSale { get; set; } = null!;
}
