using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWAtcMainNew
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string AtcNo { get; set; } = null!;

    public DateOnly? AtcDate { get; set; }

    public double? TotalAmount { get; set; }

    public double? TotalAmountCp { get; set; }

    public double? TotalAmountMcl { get; set; }
}
