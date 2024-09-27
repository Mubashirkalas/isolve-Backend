using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DealPurchaseDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public int FileNo { get; set; }

    public double? Amount { get; set; }

    public string? Status { get; set; }

    public short? AreaId { get; set; }

    public byte? PropertyType { get; set; }

    public string? FormNo { get; set; }

    public virtual DealPurchase DealPurchase { get; set; } = null!;

    public virtual QuotaAllocationDetail? QuotaAllocationDetail { get; set; }
}
