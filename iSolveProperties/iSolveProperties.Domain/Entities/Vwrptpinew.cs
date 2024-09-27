using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Vwrptpinew
{
    public string PiNo { get; set; } = null!;

    public string? PiType { get; set; }

    public string? PiNature { get; set; }

    public DateTime? PiDate { get; set; }

    public string? CcCode { get; set; }

    public string? PiLocalho { get; set; }

    public string? CcDesc { get; set; }

    public string? PiItemno { get; set; }

    public decimal? PiQty { get; set; }

    public DateTime? PiReqdate { get; set; }

    public decimal? PiRate { get; set; }

    public int TrEntr { get; set; }

    public string? PidRemarks { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? ItPartno { get; set; }

    public string? Remarks { get; set; }

    public string? Make { get; set; }

    public string? Addres { get; set; }

    public string? MillRef { get; set; }

    public string? Year { get; set; }

    public decimal? Bal { get; set; }

    public int CompId { get; set; }

    public decimal? Cqty { get; set; }

    public decimal? Commurece { get; set; }

    public decimal? Commuissue { get; set; }

    public decimal? CValue { get; set; }

    public int Lastyearflag { get; set; }
}
