using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPartyPaymentMasterDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public double? AdvanceBalance { get; set; }

    public double? InvoiceBalance { get; set; }

    public double? SecurityBalance { get; set; }

    public double? ApaccrualBalance { get; set; }

    public double? NetBalance { get; set; }

    public string? Bptype { get; set; }

    public string? PaymentAgainst { get; set; }

    public string? PaymentMode { get; set; }

    public string? AccountNumber { get; set; }

    public string? SlipNo { get; set; }

    public DateOnly? SlipDate { get; set; }

    public double? Amount { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }

    public short? MuserId { get; set; }

    public int? Sno { get; set; }

    public string? DocNo { get; set; }

    public string? DocType { get; set; }

    public DateOnly? DocDate { get; set; }

    public DateOnly? PostingDate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? AmountPayable { get; set; }

    public double? Discount { get; set; }

    public double? DiscountValue { get; set; }

    public double? SalesTax { get; set; }

    public double? AdvanceIncomeTax { get; set; }

    public double? AmountToBePaid { get; set; }

    public double? TotalPayment { get; set; }

    public string? Ipno { get; set; }

    public double? AmountPaid { get; set; }

    public string SubSegmentName1 { get; set; } = null!;
}
