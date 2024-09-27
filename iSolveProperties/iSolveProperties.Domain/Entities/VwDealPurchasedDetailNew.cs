using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDealPurchasedDetailNew
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public int? FileNo { get; set; }

    public double? Amount { get; set; }

    public string? Status { get; set; }

    public short? AreaId { get; set; }

    public string? AreaName { get; set; }

    public byte? PropertyType { get; set; }

    public string? Property { get; set; }

    public bool? FormNo { get; set; }
}
