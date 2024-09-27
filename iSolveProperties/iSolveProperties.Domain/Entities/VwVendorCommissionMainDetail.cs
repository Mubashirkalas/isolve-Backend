using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwVendorCommissionMainDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public string? Bpcode { get; set; }

    public DateOnly? ApplicableDate { get; set; }

    public string? AreaSerialNo { get; set; }

    public double? CommissionPercentage { get; set; }

    public double? CommissionValue { get; set; }

    public int? Sno { get; set; }

    public double? ConfirmationPercentage { get; set; }

    public double? ConfirmationAmount { get; set; }
}
