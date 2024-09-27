using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TestCostCenterDetail
{
    public short? Sno { get; set; }

    public int? TestProcedureCode { get; set; }

    public double? Amount { get; set; }

    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Bpcode { get; set; }

    public virtual TestCostCenterMain? TestCostCenterMain { get; set; }

    public virtual TestIssue? TestIssue { get; set; }
}
