using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectRescheduleDetail
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public int? Sno { get; set; }

    public string? Description { get; set; }

    public DateOnly? Date { get; set; }

    public decimal? Amount { get; set; }

    public string? Status { get; set; }

    public string? StatusUpdationKey { get; set; }

    public decimal? TotalPaidAmount { get; set; }

    public decimal? NetPayableAmount { get; set; }

    public DateOnly? PaidDate { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? PaymentMode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Remarks { get; set; }

    public string? LatePaymentChargesStatus { get; set; }

    public decimal? LateChargesTotal { get; set; }

    public decimal? LateChargesPaid { get; set; }

    public decimal? LateChargesPayable { get; set; }

    public string? NewDescription { get; set; }

    public DateOnly? NewDueDate { get; set; }

    public decimal? NewDueAmount { get; set; }

    public virtual ProjectReschedule ProjectReschedule { get; set; } = null!;
}
