using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalarySheetDeductionDetail
{
    public string? Title { get; set; }

    public string? EmployeeName { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? EmployeeSrno { get; set; }

    public string? Code { get; set; }

    public string? VType { get; set; }

    public double? Amount { get; set; }

    public double? Deduction { get; set; }
}
