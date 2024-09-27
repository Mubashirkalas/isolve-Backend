using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Domain1
{
    public int SNo { get; set; }

    public DateTime? SDate { get; set; }

    public string SMainKey { get; set; } = null!;

    public int? SInvno { get; set; }

    public DateTime? SInvdate { get; set; }

    public string? SType { get; set; }

    public int? SOwgpNo { get; set; }

    public DateTime? SOwgpDate { get; set; }

    public string? SBuyer { get; set; }

    public string? SSupplier { get; set; }

    public int CompId { get; set; }

    public string SYear { get; set; } = null!;

    public double? SStper { get; set; }

    public string? SAccountskey { get; set; }

    public string? SOrderNo { get; set; }

    public DateTime? SOrderDate { get; set; }

    public string? SRefNo { get; set; }

    public DateTime? SRefDate { get; set; }

    public string? SVehicle { get; set; }

    public string? SBilty { get; set; }

    public string? SDriver { get; set; }

    public string? Ogpno { get; set; }

    public DateOnly? Ogpdate { get; set; }
}
