using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Zerob
{
    public string Keyfield { get; set; } = null!;

    public string Grnno { get; set; } = null!;

    public string? Type { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Gpno { get; set; }

    public DateOnly? Gpdate { get; set; }

    public string? Billno { get; set; }

    public string? Ref { get; set; }

    public string? Lot { get; set; }

    public string? PrtyName { get; set; }

    public string? Party { get; set; }

    public string? TrItemno { get; set; }

    public decimal TrQty { get; set; }

    public string? TrPo { get; set; }

    public string? TrConstyp { get; set; }

    public decimal TrAccept { get; set; }

    public decimal TrValue { get; set; }

    public string? TrFoc { get; set; }

    public decimal? TrFr { get; set; }

    public decimal? TrOther { get; set; }

    public decimal? TrPacking { get; set; }

    public decimal? TrZilatax { get; set; }

    public decimal? TrOctory { get; set; }

    public decimal? TrCartrage { get; set; }

    public int? TrEntr { get; set; }

    public string? CcDesc { get; set; }

    public string? MchDesc { get; set; }

    public string? TrWo { get; set; }

    public string? TrCc { get; set; }

    public string? TrMch { get; set; }

    public string? WoDesc { get; set; }

    public decimal? CcBudget { get; set; }

    public string? ItCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public string? ItLoc { get; set; }

    public string? ItPartno { get; set; }

    public decimal ItOpbal { get; set; }

    public decimal ItOpagval { get; set; }

    public decimal ItCbal { get; set; }

    public decimal ItAvgval { get; set; }

    public decimal ItRoqty { get; set; }

    public bool? ItImp { get; set; }

    public string? ItPgl { get; set; }

    public string? ItCgl { get; set; }

    public string? ItNotes { get; set; }

    public int? CompId { get; set; }

    public string? Abbr { get; set; }

    public string? MPono { get; set; }

    public decimal? TrStax { get; set; }
}
