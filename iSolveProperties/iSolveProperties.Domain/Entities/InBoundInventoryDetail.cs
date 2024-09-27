using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InBoundInventoryDetail
{
    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public short? Sno { get; set; }

    public string? FinancialYear { get; set; }

    public short? ProjectId { get; set; }

    public short? SizeId { get; set; }

    public string? Qty { get; set; }

    public int? Amount { get; set; }

    public int? AmountInCash { get; set; }

    public int? AmountInBank { get; set; }

    public string? ExpectedReturn { get; set; }

    public int? Days { get; set; }

    public virtual AreaDetail? AreaDetail { get; set; }

    public virtual ProjectRegistration? ProjectRegistration { get; set; }
}
