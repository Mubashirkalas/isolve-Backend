using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwDoreturnIp
{
    public string Srno { get; set; } = null!;

    public string DoNo { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string FYear { get; set; } = null!;

    public byte CompId { get; set; }

    public DateOnly? DoDate { get; set; }

    public string? GroupCode { get; set; }

    public string? ItemCode { get; set; }

    public string? Uom { get; set; }

    public string? DoReturnNo { get; set; }

    public double? TotalInvoiceValue { get; set; }

    public double? QytCylinder { get; set; }

    public double? RQty { get; set; }
}
