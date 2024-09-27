using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class SalaryScaleMain
{
    public byte CompId { get; set; }

    public string SrNo { get; set; } = null!;

    public string? Year { get; set; }

    public string? Grade { get; set; }

    public string? Designation { get; set; }
}
