using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetDisposalDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short? Sno { get; set; }

    public string? AssetId { get; set; }

    public double? NetAmount { get; set; }

    public string? AssetDescription { get; set; }

    public int? AmountPurchased { get; set; }

    public string? Type { get; set; }

    public int? SalesAmount { get; set; }

    public int? DepreciationPosted { get; set; }

    public int? Expr1 { get; set; }
}
