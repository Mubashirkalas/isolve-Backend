using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EmployeeRegistrationSalaryDetail
{
    public byte? CompId { get; set; }

    public int? SrNo { get; set; }

    public short? SNo { get; set; }

    public string? PayrollExpense { get; set; }

    public string? PerquisitesCode { get; set; }

    public string? Type { get; set; }

    public double? Amount { get; set; }

    public double? Percentage { get; set; }

    public string? Per { get; set; }

    public byte? BankId { get; set; }

    public string? AccountNo { get; set; }

    public string? SalaryPayable { get; set; }

    public string? TaxPayableCode { get; set; }

    public virtual EmployeeRegistrationMain? EmployeeRegistrationMain { get; set; }
}
