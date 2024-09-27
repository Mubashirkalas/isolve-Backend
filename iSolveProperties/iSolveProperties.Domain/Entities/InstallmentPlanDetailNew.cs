using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class InstallmentPlanDetailNew
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public byte AmountPercentage { get; set; }

    public short? SubSegmentId { get; set; }

    public short? Sno { get; set; }

    public string? Description { get; set; }

    public string? Amount { get; set; }

    public string? Spcommission { get; set; }

    public string? Tlcommission { get; set; }

    public string? DealerCommission { get; set; }

    public string? StatusInstallment { get; set; }

    public string? ReceiptNo { get; set; }

    public virtual InstallmentPlanNew InstallmentPlanNew { get; set; } = null!;
}
