using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwPendingGrn
{
    public string? Value { get; set; }

    public string? BpCode { get; set; }

    public string? DocType { get; set; }

    public string? DocDate { get; set; }

    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string? DocNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Status { get; set; }

    public double? SalesTaxReceivable { get; set; }

    public string? TotalValue { get; set; }
}
