using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPaymentPlanReport
{
    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string Srno { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? Keys { get; set; }

    public string? Bpcode { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public string? PropertyDescription { get; set; }

    public string? Psdsuk { get; set; }

    public int? Sno { get; set; }

    public string? Description { get; set; }

    public DateOnly? DueDate { get; set; }

    public decimal? DueAmount { get; set; }

    public string? Status { get; set; }

    public string? StatusUpdationKey { get; set; }

    public decimal? TotalPaidAmount { get; set; }

    public decimal? NetPayableAmount { get; set; }

    public DateOnly? PaidDate { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? PaymentMode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Remarks { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public double? TotalPriceOfProperty { get; set; }

    public string? Bpname { get; set; }

    public string? Cnic { get; set; }

    public string? ConfirmationReceipt { get; set; }

    public string? BookingFormNo { get; set; }
}
