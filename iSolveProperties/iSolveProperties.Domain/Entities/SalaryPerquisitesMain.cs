using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalaryPerquisitesMain
{
    public byte CompId { get; set; }

    public string SrNo { get; set; } = null!;

    public string? Year { get; set; }

    public string? PayrollExpense { get; set; }

    public string? Title { get; set; }

    public string? Type { get; set; }

    public double? Amount { get; set; }

    public double? Percentage { get; set; }

    public string? Per { get; set; }

    public string? SalaryPayable { get; set; }

    public string? SalaryTaxExpense { get; set; }

    public string? ProvisionForTaxtation { get; set; }
}
