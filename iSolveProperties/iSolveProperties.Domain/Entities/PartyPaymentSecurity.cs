using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PartyPaymentSecurity
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public short? Sno { get; set; }

    public string? ItemCode { get; set; }

    public string? GroupCode { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Spc { get; set; }

    public double? Total { get; set; }
}
