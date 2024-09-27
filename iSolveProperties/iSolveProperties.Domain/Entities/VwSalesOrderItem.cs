using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalesOrderItem
{
    public byte? SNo { get; set; }

    public string? ItemCode { get; set; }

    public string? ItemName { get; set; }

    public string? UnitOfMeasurement { get; set; }

    public int? CylinderQuantity { get; set; }

    public double? M3 { get; set; }

    public double? Kg { get; set; }

    public double? UnitRate { get; set; }

    public double? InvoiceValue { get; set; }

    public double? FreightPerUnit { get; set; }

    public double? TotalFreight { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public int? SrNo { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public string? ItemGroup { get; set; }
}
