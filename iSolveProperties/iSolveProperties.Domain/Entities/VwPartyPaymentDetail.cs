using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPartyPaymentDetail
{
    public string IpsubSegmentName { get; set; } = null!;

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public int? Sno { get; set; }

    public string? Ipsrno { get; set; }

    public string? Ipno { get; set; }

    public DateOnly? Ipdate { get; set; }

    public byte? IpsubSegment { get; set; }

    public string? DocSrno { get; set; }

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

    public double? AmountPaid { get; set; }

    public string? Vin { get; set; }

    public DateOnly? Vindate { get; set; }

    public short? Ipsno { get; set; }
}
