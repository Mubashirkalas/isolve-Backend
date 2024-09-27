using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class GrnWithPoMaster
{
    public int? GrnNo { get; set; }

    public string? Type { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Gpno { get; set; }

    public string? Party { get; set; }

    public string? Billno { get; set; }

    public string? Ref { get; set; }

    public string? Lot { get; set; }

    public decimal? TotalAmount { get; set; }

    public string? KeyField { get; set; }

    public int? InspNo { get; set; }

    public string? Year { get; set; }

    public string? AccountsKey { get; set; }

    public DateOnly? Vdate { get; set; }

    public DateOnly? Billdate { get; set; }

    public string? Posted { get; set; }

    public string? SUser { get; set; }

    public int? CompId { get; set; }

    public int? TrUserid { get; set; }

    public string? TrWorkstation { get; set; }

    public string? TrUsername { get; set; }

    public DateOnly? TrCreationDate { get; set; }

    public string? Staxcode { get; set; }

    public string? MPono { get; set; }

    public string? MDesc { get; set; }

    public bool? IsLocal { get; set; }

    public string? DoNo { get; set; }
}
