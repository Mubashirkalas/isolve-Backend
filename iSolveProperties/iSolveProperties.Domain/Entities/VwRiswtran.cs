using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRiswtran
{
    public string? TrItemno { get; set; }

    public decimal Receipt { get; set; }

    public decimal ReceiptV { get; set; }

    public decimal Issue { get; set; }

    public decimal IssueV { get; set; }

    public decimal Sale { get; set; }

    public decimal SaleV { get; set; }
}
