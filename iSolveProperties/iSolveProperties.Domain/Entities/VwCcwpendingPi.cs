using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCcwpendingPi
{
    public string PiNo { get; set; } = null!;

    public DateTime? PiDate { get; set; }

    public string? PiItemno { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public decimal? PiQty { get; set; }

    public decimal? PiRate { get; set; }

    public string CcCode { get; set; } = null!;

    public string? CcDesc { get; set; }

    public bool? Posted { get; set; }

    public int CompId { get; set; }

    public decimal? BalanceQty { get; set; }
}
