using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDealerQuotum
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int SerialNo { get; set; }

    public short SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public string Pisrno { get; set; } = null!;

    public string Bpcode { get; set; } = null!;

    public short SuserId { get; set; }

    public string SworkStation { get; set; } = null!;

    public string SuserName { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? CompanyName { get; set; }

    public string? UserName { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? PiserialNo { get; set; }

    public string? Bpname { get; set; }

    public string? ProjectName { get; set; }

    public string Pify { get; set; } = null!;
}
