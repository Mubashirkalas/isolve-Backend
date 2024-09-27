using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TempIpPurchase
{
    public bool? SelectCheck { get; set; }

    public short? Srno { get; set; }

    public string? DoNo { get; set; }

    public DateOnly? DoDate { get; set; }

    public byte? SubSegmentIdDetail { get; set; }

    public string? SubSegmentNameDetail { get; set; }

    public double? TotalValue { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? Year { get; set; }

    public byte? CompId { get; set; }

    public short? UserId { get; set; }

    public string? IpNo { get; set; }

    public DateOnly? IpDate { get; set; }

    public string? DocType { get; set; }

    public string? DebitMemoNo { get; set; }

    public DateOnly? DebitMemoDate { get; set; }

    public double? DebitAmount { get; set; }

    public double? SalesTaxReceivable { get; set; }

    public string? PostedBy { get; set; }

    public double? AmountToBeReceived { get; set; }

    public string? Vin { get; set; }

    public DateOnly? Vindate { get; set; }
}
