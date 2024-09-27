using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AssetAdditionModificationDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string Keys { get; set; } = null!;

    public string FinancialYear { get; set; } = null!;

    public int TypeId { get; set; }

    public int Amount { get; set; }

    public short BranchId { get; set; }

    public string Bpcode { get; set; } = null!;

    public string Description { get; set; } = null!;

    public short Sno { get; set; }

    public string Location { get; set; } = null!;

    public string? NewLocation { get; set; }

    public virtual AssetAdditionModification AssetAdditionModification { get; set; } = null!;

    public virtual AssetType AssetType { get; set; } = null!;
}
