using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalaryDispersementBankDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public int? EmployeeBankId { get; set; }

    public double? Amount { get; set; }

    public int? BankId { get; set; }

    public string? AccountNumber { get; set; }

    public string? ChequeNo { get; set; }

    public DateOnly? ChequeDate { get; set; }

    public string? EmployeeBank { get; set; }

    public string? AccountTitle { get; set; }

    public string? BankName { get; set; }
}
