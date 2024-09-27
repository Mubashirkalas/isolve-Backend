using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ItemBoqplan
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public short ProjectId { get; set; }

    public short BlockId { get; set; }

    public short SubletId { get; set; }

    public short SuserId { get; set; }

    public string SuserName { get; set; } = null!;

    public string SworkStation { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual BlocksDetail BlocksDetail { get; set; } = null!;

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual ProjectRegistration ProjectRegistration { get; set; } = null!;

    public virtual SubSegment SubSegment { get; set; } = null!;

    public virtual User Suser { get; set; } = null!;
}
