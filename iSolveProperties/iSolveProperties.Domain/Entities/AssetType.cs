using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AssetType
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public string Type { get; set; } = null!;

    public int DepreciationRate { get; set; }

    public string? AssetId { get; set; }

    public string? AccumulatedDepreciationId { get; set; }

    public string? DepreciationExpenseId { get; set; }

    public string? OtherIncomeId { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public virtual ICollection<Depreciation> Depreciations { get; set; } = new List<Depreciation>();
}
