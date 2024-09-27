using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetType
{
    public string Asset { get; set; } = null!;

    public string AccumulatedDepreciation { get; set; } = null!;

    public string DepreciationExpense { get; set; } = null!;

    public string OtherIncome { get; set; } = null!;

    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public string Type { get; set; } = null!;

    public int DepreciationRate { get; set; }

    public string? AssetId { get; set; }

    public string? AccumulatedDepreciationId { get; set; }

    public string? DepreciationExpenseId { get; set; }

    public string? OtherIncomeId { get; set; }
}
