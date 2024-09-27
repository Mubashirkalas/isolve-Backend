using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Pim
{
    public string PiNo { get; set; } = null!;

    public DateTime? PiDate { get; set; }

    public string? PiType { get; set; }

    public string? PiNature { get; set; }

    public string? CcCode { get; set; }

    public decimal? TotalAmount { get; set; }

    public string KeyField { get; set; } = null!;

    public string? Year { get; set; }

    public string? SUser { get; set; }

    public int CompId { get; set; }

    public string? Remarks { get; set; }

    public bool? Posted { get; set; }

    public string? MillRef { get; set; }

    public string? PiLocalHo { get; set; }
}
