using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalaryScaleMainDetail
{
    public byte CompId { get; set; }

    public string SrNo { get; set; } = null!;

    public string? Year { get; set; }

    public string? Grade { get; set; }

    public string? Designation { get; set; }

    public short? SNo { get; set; }

    public string? PayrollExpensedesc { get; set; }

    public string? Type { get; set; }

    public double? Amount { get; set; }

    public double? Percentage { get; set; }

    public string? Per { get; set; }

    public string? PerquisitesCode { get; set; }

    public string? Title { get; set; }

    public string? DesgTitle { get; set; }

    public string? PayrollExpense { get; set; }

    public string? SalaryPayable { get; set; }

    public string? SalaryPayabledesc { get; set; }
}
