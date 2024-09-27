using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwEcrReport
{
    public string? RefNo { get; set; }

    public string? EcrNo { get; set; }

    public string? Date { get; set; }

    public string? Vehicle { get; set; }

    public string? BPName { get; set; }

    public string? Route { get; set; }

    public string? Product { get; set; }

    public string? Ownership { get; set; }

    public string? Capacity { get; set; }

    public int? Total { get; set; }

    public int? Ok { get; set; }

    public int? Sts { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public short? Sno { get; set; }

    public string? PartyCode { get; set; }

    public DateOnly? EcrDate { get; set; }
}
