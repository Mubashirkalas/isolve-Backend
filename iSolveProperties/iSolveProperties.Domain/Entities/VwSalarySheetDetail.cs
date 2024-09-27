using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalarySheetDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? EmployeeSrno { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DesignationCode { get; set; }

    public int? TotalDays { get; set; }

    public int? Leaves { get; set; }

    public double? LateHours { get; set; }

    public double? OvertimeHours { get; set; }

    public int? Absents { get; set; }

    public int? WorkDays { get; set; }

    public double? BasicSalary { get; set; }

    public double? Overtime { get; set; }

    public double? Bonus { get; set; }

    public double? Incentive { get; set; }

    public double? GrossSalary { get; set; }

    public double? AdvanceReceiveable { get; set; }

    public double? AdvanceDeducted { get; set; }

    public double? LoanReceiveable { get; set; }

    public double? LoanDeducted { get; set; }

    public double? NetSalary { get; set; }

    public string? Remarks { get; set; }

    public string? DesignationTitle { get; set; }

    public string? DepartmentName { get; set; }

    public string? EmployeeName { get; set; }

    public string? BioMetricId { get; set; }

    public double? RemainingBasicSalary { get; set; }

    public double? RemainingOverTime { get; set; }

    public double? RemainingBonus { get; set; }

    public double? RemainingIncentive { get; set; }

    public string? Status { get; set; }

    public string? EmployeeBank { get; set; }

    public string? EmployeeAccount { get; set; }

    public double? Tax { get; set; }

    public string? EmploymentType { get; set; }

    public double? Gratuity { get; set; }

    public double? SocialSecurity { get; set; }

    public double? ProvidentFund { get; set; }

    public double? LeaveEncashment { get; set; }

    public string? EmployeeBankName { get; set; }

    public int? DeductionAmount { get; set; }
}
