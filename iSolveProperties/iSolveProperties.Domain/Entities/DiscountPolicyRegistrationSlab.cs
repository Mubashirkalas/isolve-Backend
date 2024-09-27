using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class DiscountPolicyRegistrationSlab
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? DiscountTypeCode { get; set; }

    public string? ParentGroupCode { get; set; }

    public double? RangeFrom { get; set; }

    public double? RangeTo { get; set; }

    public double? Discount { get; set; }

    public virtual DiscountPolicyRegistration DiscountPolicyRegistration { get; set; } = null!;
}
