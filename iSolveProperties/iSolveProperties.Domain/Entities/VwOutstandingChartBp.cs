using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwOutstandingChartBp
{
    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public double? Advance { get; set; }

    public double? Receivable { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? PartyType { get; set; }
}
