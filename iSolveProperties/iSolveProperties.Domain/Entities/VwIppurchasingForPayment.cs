using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwIppurchasingForPayment
{
    public string? Status { get; set; }

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte IpsubSegment { get; set; }

    public string Ipno { get; set; } = null!;

    public string Bpcode { get; set; } = null!;

    public DateOnly? Ipdate { get; set; }

    public string? PartyType { get; set; }

    public string? Bpname { get; set; }

    public string IpsubSegmentName { get; set; } = null!;

    public string? Docno { get; set; }

    public string? Doctype { get; set; }

    public double? InvoiceValue { get; set; }

    public double? AmountPayable { get; set; }

    public string? Vin { get; set; }

    public DateOnly? Vindate { get; set; }

    public double? AmountToBePaid { get; set; }

    public double? Amount { get; set; }

    public double? SalesTax { get; set; }

    public string? Docsrno { get; set; }

    public DateOnly? DocDate { get; set; }
}
