using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalarySlip
{
    public byte? BankId { get; set; }

    public string? BankName { get; set; }

    public string? AccountTitle { get; set; }

    public string? EmployeeName { get; set; }

    public string? DepartmentName { get; set; }

    public string DesignationTitle { get; set; } = null!;

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? EmployeeSrno { get; set; }

    public string? SalarySheetSrno { get; set; }

    public DateOnly? FromDate { get; set; }

    public DateOnly? ToDate { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DesignationCode { get; set; }

    public string? AccountNumber { get; set; }

    public string? ChequeSlipNo { get; set; }

    public DateOnly? ChequeSlipDate { get; set; }

    public double? BasicSalary { get; set; }

    public double? PaidSalary { get; set; }

    public double? Overtime { get; set; }

    public double? PaidOvertime { get; set; }

    public double? Bonus { get; set; }

    public double? PaidBonus { get; set; }

    public double? Incentive { get; set; }

    public double? PaidIncentive { get; set; }

    public double? AdvanceReceiveable { get; set; }

    public double? AdvanceDeducted { get; set; }

    public double? LoanReceiveable { get; set; }

    public double? LoanDeducted { get; set; }

    public double? TotalValue { get; set; }

    public double? BankPaid { get; set; }

    public double? CashPaid { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? SalarySheetSerialNo { get; set; }

    public string SubSegmentName { get; set; } = null!;
}
