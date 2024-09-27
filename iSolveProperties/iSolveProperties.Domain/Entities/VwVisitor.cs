using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwVisitor
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

    public short SuserId { get; set; }

    public string SuserName { get; set; } = null!;

    public string SworkStation { get; set; } = null!;

    public DateTime ScreationDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Types { get; set; }

    public DateTime? TimeIn { get; set; }

    public DateTime? TimeOut { get; set; }

    public string? Source { get; set; }

    public string? Pocname { get; set; }

    public string? RefferedById { get; set; }

    public string? RefferedBy { get; set; }

    public string? Remarks { get; set; }
}
