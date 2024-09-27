using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PartyChartofAcct
{
    public string GlCode { get; set; } = null!;

    public string? Name { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public string? ItPgl { get; set; }

    public string? ItCgl { get; set; }

    public string? AdAddress1 { get; set; }

    public string? AdAddress2 { get; set; }

    public string? AdCity { get; set; }

    public string? AdCountry { get; set; }

    public string? AdPhone { get; set; }

    public string? AdFax { get; set; }

    public string? AdEmail { get; set; }

    public string? AdContactperson { get; set; }

    public string? AdCpphone { get; set; }

    public string? AdCpemail { get; set; }

    public string? AdNtn { get; set; }

    public string? AdStreg { get; set; }

    public int CompId { get; set; }

    public string GlYear { get; set; } = null!;

    public string? AdPaymentTerms { get; set; }
}
