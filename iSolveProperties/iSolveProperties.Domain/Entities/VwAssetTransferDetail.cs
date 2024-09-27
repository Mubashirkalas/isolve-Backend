using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetTransferDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short Sno { get; set; }

    public string Aamdkeys { get; set; } = null!;

    public string? Branch { get; set; }

    public string? Type { get; set; }

    public int? Amount { get; set; }

    public string? Description { get; set; }

    public string? Vendor { get; set; }

    public string? Bpcode { get; set; }

    public int? TypeId { get; set; }

    public short? BranchId { get; set; }

    public string? Location { get; set; }

    public int? DepreciationRate { get; set; }
}
