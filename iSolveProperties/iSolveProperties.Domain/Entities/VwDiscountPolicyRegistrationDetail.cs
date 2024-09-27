using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDiscountPolicyRegistrationDetail
{
    public string? DiscountTitle { get; set; }

    public string? ParentGroupName { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? DiscountTypeCode { get; set; }

    public string? DiscountType { get; set; }

    public string? ParentGroupCode { get; set; }

    public double? Discount { get; set; }

    public string? Remarks { get; set; }

    public string? SalesType { get; set; }

    public string? DiscountCriteria { get; set; }
}
