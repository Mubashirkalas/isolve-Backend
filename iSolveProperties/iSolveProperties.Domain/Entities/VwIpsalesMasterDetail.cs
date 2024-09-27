using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwIpsalesMasterDetail
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string Ipno { get; set; } = null!;

    public string Bpcode { get; set; } = null!;

    public DateOnly? Ipdate { get; set; }

    public string? Bptype { get; set; }

    public double? AdvanceBalance { get; set; }

    public double? InvoiceBalance { get; set; }

    public double? SecurityBalance { get; set; }

    public double? ApaccuralBalance { get; set; }

    public short? Userid { get; set; }

    public string? WorkSation { get; set; }

    public string? Username { get; set; }

    public DateTime? CreationDate { get; set; }

    public short? ModifiedUserId { get; set; }

    public string? ModifiedWorkstation { get; set; }

    public string? ModifiedUsername { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Sinkey { get; set; }

    public string? VoucherKey { get; set; }

    public string? DispatchInvoices { get; set; }

    public string? PostedBy { get; set; }

    public string? DocNo { get; set; }

    public DateOnly? DocDate { get; set; }

    public string? DocType { get; set; }

    public byte? SubSegmentIddetail { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public double? Qty { get; set; }

    public double? Amount { get; set; }

    public double? RemainingAmount { get; set; }

    public double? UnitRate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SalesTax { get; set; }

    public double? SalesTaxPayable { get; set; }

    public double? Cgsvalue { get; set; }

    public string? DeliveryAddress { get; set; }

    public double? FurtherTax { get; set; }

    public double? TotalValue { get; set; }

    public string? Freight { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? CreditMemono { get; set; }

    public DateOnly? CreditMemoDate { get; set; }

    public double? TotalNetValue { get; set; }

    public double? CreditMemoAmount { get; set; }

    public string? RouteId { get; set; }

    public string? VehicleId { get; set; }

    public DateOnly? DeliveryDate { get; set; }

    public string? Status { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? BusinessPartnersName { get; set; }

    public string? Itemname { get; set; }

    public string? GroupName { get; set; }

    public string? RegionId { get; set; }

    public string? RegionName { get; set; }

    public string? PartyType { get; set; }

    public string? Name { get; set; }

    public string? Brand { get; set; }

    public string? Category { get; set; }
}
