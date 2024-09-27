using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PidLog
{
    public int LogSerial { get; set; }

    public string? PiItemno { get; set; }

    public decimal? PiQty { get; set; }

    public decimal? PiValue { get; set; }

    public DateTime? PiReqdate { get; set; }

    public decimal? PiRate { get; set; }

    public int TrEntr { get; set; }

    public string KeyField { get; set; } = null!;

    public string? PiPono { get; set; }

    public string? Year { get; set; }

    public string? PiNo { get; set; }

    public int CompId { get; set; }

    public string? Make { get; set; }

    public decimal? BalanceQty { get; set; }

    public bool? Posted { get; set; }

    public string? PidRemarks { get; set; }
}
