using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PartyPaymentDetail
{
    public string? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public short? Sno { get; set; }

    public bool? Select { get; set; }

    public string? DocNo { get; set; }

    public string? DocType { get; set; }

    public DateOnly? DocDate { get; set; }

    public DateOnly? PostingDate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? AmountPayable { get; set; }

    public double? CashDiscount { get; set; }

    public double? SalesTax { get; set; }

    public double? AdvanceIncomeTax { get; set; }

    public double? AmountToBePaid { get; set; }

    public double? TotalPayment { get; set; }

    public string? IpNo { get; set; }

    public double? AmountPaid { get; set; }

    public string? Vin { get; set; }

    public DateOnly? Vindate { get; set; }

    public virtual PartyPaymentMain? PartyPaymentMain { get; set; }
}
