using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TestCostCenterMain
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? Ecrno { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? Year { get; set; }

    public string? Bpcode { get; set; }
}
