using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Visitor
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short SubSegmentId { get; set; }

    public DateOnly Date { get; set; }

    public string VisitorName { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string Purpose { get; set; } = null!;

    public int? Poc { get; set; }

    public string Type { get; set; } = null!;

    public string? Types { get; set; }

    public short SuserId { get; set; }

    public string SuserName { get; set; } = null!;

    public string SworkStation { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public DateTime? TimeIn { get; set; }

    public DateTime? TimeOut { get; set; }

    public string? Source { get; set; }

    public string? RefferedById { get; set; }

    public string? Remarks { get; set; }

    public virtual SubSegment SubSegment { get; set; } = null!;

    public virtual User Suser { get; set; } = null!;
}
