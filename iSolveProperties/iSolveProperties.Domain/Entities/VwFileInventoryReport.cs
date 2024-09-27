using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwFileInventoryReport
{
    public string? SerialNo { get; set; }

    public string? FileNo { get; set; }

    public double? Amount { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public string? Bpcode { get; set; }

    public byte CompId { get; set; }

    public string? Bpname { get; set; }
}
