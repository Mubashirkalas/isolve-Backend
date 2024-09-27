using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalaryPerquisitesDetail
{
    public string Year { get; set; } = null!;

    public byte CompId { get; set; }

    public string SrNo { get; set; } = null!;

    public short? SNo { get; set; }

    public short? GlCode { get; set; }

    public string? PerquisitesTittle { get; set; }

    public string? Type { get; set; }

    public double? Amount { get; set; }

    public double? Percentage { get; set; }

    public string? Per { get; set; }

    public virtual SalaryPerquisitesMain SalaryPerquisitesMain { get; set; } = null!;
}
