using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class JobOrderDriverLoader
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? JobOrderNo { get; set; }

    public short? Sno { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public string? ContactNo { get; set; }

    public double? Charges { get; set; }
}
