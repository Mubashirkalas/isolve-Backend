using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRiswtransStSum
{
    public string? TrItemno { get; set; }

    public decimal Receipt { get; set; }

    public decimal ReceiptV { get; set; }

    public decimal Consumption { get; set; }

    public decimal ConsumptionV { get; set; }

    public decimal Capitalized { get; set; }

    public decimal CapitalizedV { get; set; }

    public decimal Issue { get; set; }

    public decimal IssueV { get; set; }

    public decimal Sale { get; set; }

    public decimal SaleV { get; set; }

    public int? CompId { get; set; }
}
