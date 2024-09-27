﻿using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDispatchMasterDetail
{
    public string SrNo { get; set; } = null!;

    public string? DispatchNo { get; set; }

    public DateOnly? Date { get; set; }

    public byte? SubSegment { get; set; }

    public string SubSegmentname { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public short? Sno { get; set; }

    public string? BpCode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? PostedBy { get; set; }

    public string? DocNo { get; set; }

    public DateOnly? DocDate { get; set; }

    public string? DocType { get; set; }

    public byte? SubSegmentId { get; set; }

    public string SubSegmentName1 { get; set; } = null!;

    public string? GroupCode { get; set; }

    public string? ItDesc { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? Uom { get; set; }

    public double? CylinderQty { get; set; }

    public double? KgQty { get; set; }

    public double? M3 { get; set; }

    public double? Ltr { get; set; }

    public double? UnitRate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? SalesTax { get; set; }

    public double? SalesTaxPayable { get; set; }

    public double? FuthurTax { get; set; }

    public double? TotalValue { get; set; }

    public string? Freight { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public string? CreditMemoNo { get; set; }

    public DateOnly? CreditMemoDate { get; set; }

    public double? CreditMemoAmount { get; set; }

    public double? TotalNetValue { get; set; }

    public double? AmountReceived { get; set; }

    public string? IpNo { get; set; }

    public string? IPDate { get; set; }

    public bool? SelectIpNo { get; set; }

    public double? IncomeTax { get; set; }

    public double? WhTax { get; set; }

    public short? IpSrno { get; set; }

    public double? AmountTobeReceived { get; set; }

    public string? TcsNo { get; set; }
}
