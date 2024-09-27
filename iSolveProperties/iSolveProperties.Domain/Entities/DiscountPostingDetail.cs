using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DiscountPostingDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? Grnsrno { get; set; }

    public string? ParentGroupCode { get; set; }

    public double? Value { get; set; }

    public string? DiscountType { get; set; }

    public double Discount { get; set; }

    public double? DiscountValue { get; set; }

    public string? Remarks { get; set; }

    public virtual DiscountPosting DiscountPosting { get; set; } = null!;
}
