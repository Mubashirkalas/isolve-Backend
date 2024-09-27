using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PaymentPlan
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public string? Keys { get; set; }

    public string? Bpcode { get; set; }

    public int? ProjectSaleSrno { get; set; }

    public string? PropertyDescription { get; set; }

    public string? Psdsuk { get; set; }

    public DateOnly? DueDate { get; set; }

    public double? DueAmount { get; set; }

    public double? TotalPaidAmount { get; set; }

    public double? NetPayableAmount { get; set; }

    public DateOnly? PaidDate { get; set; }

    public double? PaidAmount { get; set; }

    public string? PaymentMode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Remarks { get; set; }

    public string? CType { get; set; }

    public DateOnly? CDueDate { get; set; }

    public DateOnly? CPaidDate { get; set; }

    public double? CDueAmount { get; set; }

    public double? CPaidAmount { get; set; }

    public string? CPaymentMode { get; set; }

    public string? CReferenceNo { get; set; }

    public string? CRemarks { get; set; }

    public double? Cash { get; set; }

    public string? Bank { get; set; }

    public double? AmountInBank { get; set; }

    public double? AlreadyPaid { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? ReceiptFrom { get; set; }

    public double? Discount { get; set; }

    public bool? Approved { get; set; }

    public short? ApprovedByUserId { get; set; }

    public DateTime? ApprovedDate { get; set; }

    public string? AccountNo { get; set; }

    public int? Rebate { get; set; }

    public int? TokenAmount { get; set; }

    public virtual BusinessPartnersMain? BusinessPartnersMain { get; set; }
}
