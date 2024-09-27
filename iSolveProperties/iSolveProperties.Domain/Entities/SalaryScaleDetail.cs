using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalaryScaleDetail
{
    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string SrNo { get; set; } = null!;

    public short? SNo { get; set; }

    public string? PayrollExpense { get; set; }

    public string? PerquisitesCode { get; set; }

    public string? Type { get; set; }

    public double? Amount { get; set; }

    public double? Percentage { get; set; }

    public string? Per { get; set; }

    public string? SalaryPayable { get; set; }

    public virtual SalaryScaleMain SalaryScaleMain { get; set; } = null!;
}
