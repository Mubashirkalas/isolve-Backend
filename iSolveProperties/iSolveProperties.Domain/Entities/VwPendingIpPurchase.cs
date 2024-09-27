using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingIpPurchase
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte SubSegmentCode { get; set; }

    public string IPNo { get; set; } = null!;

    public string? Status { get; set; }

    public double SalesTaxPayable { get; set; }

    public short? SrNo1 { get; set; }

    public string? PostedBy { get; set; }

    public string? DocNo { get; set; }

    public DateOnly? DocDate { get; set; }

    public string? DocType { get; set; }

    public double? InvoiceValue { get; set; }

    public string? DebitMemoNo { get; set; }

    public DateOnly? DebitMemoDate { get; set; }

    public double? DebitMemoAmount { get; set; }

    public double? TotalNetValue { get; set; }

    public string? IPDate { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public double? AmountToBePaid { get; set; }

    public string? Vin { get; set; }

    public DateOnly? Vindate { get; set; }
}
