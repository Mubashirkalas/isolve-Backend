using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwSalesInvoiceComparison
{
    public DateOnly? SalesDate { get; set; }

    public string? BpCode { get; set; }

    public string? BarCode { get; set; }

    public double? Rate { get; set; }

    public string? SalesType { get; set; }

    public string? SalesInvoiceNo { get; set; }
}
