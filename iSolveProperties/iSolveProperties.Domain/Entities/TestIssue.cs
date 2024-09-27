using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TestIssue
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string? Issue { get; set; }

    public string? AccountCode { get; set; }
}
