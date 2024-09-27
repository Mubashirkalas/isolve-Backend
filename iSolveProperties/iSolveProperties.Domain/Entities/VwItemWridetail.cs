using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemWridetail
{
    public string? ItCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public DateOnly? Opdate { get; set; }

    public string? Grnno { get; set; }

    public string? Party { get; set; }

    public string? CcDesc { get; set; }

    public decimal? Receipt { get; set; }

    public decimal? ReceiptV { get; set; }

    public decimal Issue { get; set; }

    public decimal Issuev { get; set; }

    public string? Type { get; set; }
}
