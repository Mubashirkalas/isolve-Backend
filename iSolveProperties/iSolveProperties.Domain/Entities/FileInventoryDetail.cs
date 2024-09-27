using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FileInventoryDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? FileNo { get; set; }

    public double? Amount { get; set; }

    public string? Status { get; set; }

    public virtual FileInventory FileInventory { get; set; } = null!;
}
