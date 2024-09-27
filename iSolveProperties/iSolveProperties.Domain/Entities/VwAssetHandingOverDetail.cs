using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAssetHandingOverDetail
{
    public string FinancialYear { get; set; } = null!;

    public short Sno { get; set; }

    public string Aamdkeys { get; set; } = null!;

    public string? Branch { get; set; }

    public int Amount { get; set; }

    public string Description { get; set; } = null!;

    public string? Vendor { get; set; }

    public string Bpcode { get; set; } = null!;

    public int TypeId { get; set; }

    public short BranchId { get; set; }

    public string Location { get; set; } = null!;

    public int? DepreciationRate { get; set; }

    public string? NewLocation { get; set; }

    public string Type { get; set; } = null!;

    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string EmployeeSrno { get; set; } = null!;

    public string? EmployeeName { get; set; }
}
