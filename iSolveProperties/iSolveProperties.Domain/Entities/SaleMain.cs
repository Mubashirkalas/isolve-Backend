using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SaleMain
{
    public int SNo { get; set; }

    public string SMainKey { get; set; } = null!;

    public DateTime? SDate { get; set; }

    public int? SInvno { get; set; }

    public DateTime? SInvdate { get; set; }

    public string? SType { get; set; }

    public int? SOwgpNo { get; set; }

    public string? SBuyer { get; set; }

    public int CompId { get; set; }

    public string SYear { get; set; } = null!;

    public DateTime? SOwgpDate { get; set; }

    public string? SSupplier { get; set; }

    public double? SStper { get; set; }

    public string? SAccountskey { get; set; }

    public string? SOrderNo { get; set; }

    public DateTime? SOrderDate { get; set; }

    public int? SChallanNo { get; set; }

    public string? SInvsub { get; set; }
}
