using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwLoanAndAdvancesDeductionRulesDetail
{
    public string? SerialNo { get; set; }

    public byte? CompId { get; set; }

    public int? Sno { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? DesignationCode { get; set; }

    public string? EmployeeSrno { get; set; }

    public double? DeductionPercentage { get; set; }

    public double? DeductionAmount { get; set; }

    public string? DeductionFrequency { get; set; }

    public string? SubSegmentName { get; set; }

    public string? DesignationTitle { get; set; }

    public string? EmployeeName { get; set; }
}
