using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalaryDispersementDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? EmployeeSrno { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DesignationCode { get; set; }

    public int? WorkDays { get; set; }

    public double? BasicSalary { get; set; }

    public double? GrossSalary { get; set; }

    public double? Tax { get; set; }

    public double? AdvanceDeducted { get; set; }

    public double? LoanDeducted { get; set; }

    public double? NetSalary { get; set; }

    public string? PaymentMode { get; set; }

    public double? PaidInCash { get; set; }

    public double? PaidFromBank { get; set; }

    public int? EmployeeBankId { get; set; }

    public string? Signature { get; set; }

    public string? HandlingOfficer { get; set; }

    public string? Remarks { get; set; }

    public int? CommissionPayable { get; set; }

    public int? CommissionPaid { get; set; }

    public int? RemainingCommission { get; set; }

    public int? PaidFromCash { get; set; }

    public string? PaidFromBankAccountNo { get; set; }

    public int? FromPaidBank { get; set; }

    public virtual SalaryDispersement SalaryDispersement { get; set; } = null!;
}
