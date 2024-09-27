using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFileTradingReport
{
    public byte CompId { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? PurchaseBpname { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? FileNo { get; set; }

    public string? BookingFormNo { get; set; }

    public string? Status { get; set; }

    public double? SalesPrice { get; set; }

    public double? Gp { get; set; }

    public double? Price { get; set; }

    public string? SalesPerson { get; set; }

    public string? AreaTitle { get; set; }

    public string? PurchasedBy { get; set; }

    public string? SoldBy { get; set; }

    public string? BpcodePurchasedBy { get; set; }

    public string? BpcodeSoldBy { get; set; }

    public string? PurchaseNo { get; set; }

    public string? SaleNo { get; set; }

    public string? SalesBpname { get; set; }

    public DateOnly? Date { get; set; }

    public string? RemarksMain { get; set; }

    public string? Remarks { get; set; }

    public string? SalesRemarks { get; set; }

    public DateOnly? SalesOn { get; set; }

    public string? ProjectName { get; set; }

    public string? PlotDetail { get; set; }

    public string? PurchasingPerson { get; set; }

    public string? TypeTitle { get; set; }

    public string? BlockType { get; set; }

    public string? Area { get; set; }
}
