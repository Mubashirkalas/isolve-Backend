using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalaryDispersementBankDetail
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

    public virtual SalaryDispersement SalaryDispersement { get; set; } = null!;
}
