using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwVendorCommissionDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public int? Sno { get; set; }

    public string? AreaSerialNo { get; set; }

    public double? CommissionPercentage { get; set; }

    public double? CommissionValue { get; set; }

    public string? Area { get; set; }

    public double? ConfirmationPercentage { get; set; }

    public double? ConfirmationAmount { get; set; }

    public string? Bpcode { get; set; }

    public double? FirstInstallmentPercentage { get; set; }

    public double? FirstInstallmentAmount { get; set; }

    public double? SecondInstallmentPercentage { get; set; }

    public double? SecondInstallmentAmount { get; set; }

    public string? PlanName { get; set; }

    public DateOnly? ApplicableDate { get; set; }
}
