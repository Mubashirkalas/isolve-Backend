using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AssetTransferDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short Sno { get; set; }

    public string Aamdkeys { get; set; } = null!;

    public virtual AssetTransfer AssetTransfer { get; set; } = null!;
}
