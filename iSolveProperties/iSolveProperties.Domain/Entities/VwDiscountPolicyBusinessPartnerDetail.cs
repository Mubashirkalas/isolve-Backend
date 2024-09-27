using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDiscountPolicyBusinessPartnerDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FinancialYear { get; set; }

    public string? Bpcode { get; set; }

    public string? Bpname { get; set; }
}
