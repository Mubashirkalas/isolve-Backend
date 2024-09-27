using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalesInvoiceService
{
    public string? ServiceType { get; set; }

    public string? ServiceLine { get; set; }

    public string GlCode { get; set; } = null!;

    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public int? SNo { get; set; }

    public string? ServiceCode { get; set; }

    public double? ServiceCharges { get; set; }

    public double? Discount { get; set; }

    public double? TotalValue { get; set; }
}
