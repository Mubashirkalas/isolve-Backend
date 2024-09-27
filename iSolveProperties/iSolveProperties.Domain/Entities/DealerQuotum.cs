using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DealerQuotum
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int SerialNo { get; set; }

    public short SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public string Pisrno { get; set; } = null!;

    public string Pify { get; set; } = null!;

    public string Bpcode { get; set; } = null!;

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual BusinessPartnersMain BusinessPartnersMain { get; set; } = null!;

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual ProjectInventory ProjectInventory { get; set; } = null!;

    public virtual SubSegment SubSegment { get; set; } = null!;

    public virtual User Suser { get; set; } = null!;
}
