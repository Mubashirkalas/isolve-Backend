using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwWowridetail
{
    public string? TrWo { get; set; }

    public string? TrItemno { get; set; }

    public string? ItDesc { get; set; }

    public string? ItUnit { get; set; }

    public DateOnly? Grndate { get; set; }

    public string? Grnno { get; set; }

    public string? PrtyName { get; set; }

    public string? WoDesc { get; set; }

    public decimal Receipt { get; set; }

    public decimal ReceiptV { get; set; }

    public decimal Issue { get; set; }

    public decimal IssueV { get; set; }

    public string? Type { get; set; }
}
