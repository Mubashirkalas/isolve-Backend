using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class MiscFarmula
{
    public string Fid { get; set; } = null!;

    public string? Fname { get; set; }

    public string? Party { get; set; }

    public string? Fgoodsitcode { get; set; }

    public string? Rawgoodsitcode { get; set; }

    public int? Wastage { get; set; }

    public int? Qty1 { get; set; }

    public int? Qty2 { get; set; }

    public decimal? Rate { get; set; }

    public DateTime? Opdate { get; set; }

    public string? SUser { get; set; }
}
