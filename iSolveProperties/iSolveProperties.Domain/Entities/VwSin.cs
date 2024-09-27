using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSin
{
    public string? Grnno { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? TrItemno { get; set; }

    public decimal? TrQty { get; set; }

    public decimal? TrAccept { get; set; }

    public decimal? TrValue { get; set; }

    public double? Pono { get; set; }

    public DateOnly? Podate { get; set; }

    public double? Reqno { get; set; }

    public DateOnly? Reqdate { get; set; }

    public string? Uom { get; set; }

    public string? Supliercode { get; set; }

    public double? Rate { get; set; }

    public string? ItDesc { get; set; }

    public string? Type { get; set; }

    public string? Gpno { get; set; }

    public DateOnly? Gpdate { get; set; }

    public string? Party { get; set; }

    public string? Billno { get; set; }

    public string? Ref { get; set; }

    public string? Lot { get; set; }

    public decimal? TotalAmount { get; set; }

    public string KeyField { get; set; } = null!;

    public int? InspNo { get; set; }

    public string Year { get; set; } = null!;

    public string? AccountsKey { get; set; }

    public DateTime? Vdate { get; set; }

    public DateTime? Billdate { get; set; }

    public string? Posted { get; set; }

    public string? SUser { get; set; }

    public int CompId { get; set; }

    public int? TrUserid { get; set; }

    public string? TrWorkstation { get; set; }

    public string? TrUsername { get; set; }

    public DateTime? TrCreationDate { get; set; }

    public string? Staxcode { get; set; }

    public string? MPono { get; set; }

    public string? MDesc { get; set; }

    public bool? IsLocal { get; set; }

    public string? DoNo { get; set; }

    public string? TrPo { get; set; }

    public string? TrWo { get; set; }

    public string? TrConstyp { get; set; }

    public string? TrCc { get; set; }

    public string? TrFoc { get; set; }

    public decimal? TrFr { get; set; }

    public decimal? TrOther { get; set; }

    public string? TrMch { get; set; }

    public int TrEntr { get; set; }

    public decimal? TrPacking { get; set; }

    public decimal? TrZilatax { get; set; }

    public decimal? TrOctory { get; set; }

    public decimal? TrCartrage { get; set; }

    public decimal? TrStax { get; set; }

    public int? Expr1 { get; set; }

    public string? TrGrnno { get; set; }

    public string? TrType { get; set; }

    public string? TrMode { get; set; }

    public string? TrPino { get; set; }

    public string? StCode { get; set; }

    public decimal? Misc { get; set; }

    public double? Igpno { get; set; }

    public DateOnly? Igpdate { get; set; }

    public double? Dcno { get; set; }

    public DateOnly? Dcdate { get; set; }

    public string? CcDesc { get; set; }
}
