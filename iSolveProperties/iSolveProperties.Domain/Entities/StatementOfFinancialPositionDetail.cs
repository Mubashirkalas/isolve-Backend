using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class StatementOfFinancialPositionDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public int? Sno { get; set; }

    public string? Name { get; set; }

    public string? Glcodes { get; set; }

    public string? Classification { get; set; }

    public string? Remarks { get; set; }

    public virtual StatementOfFinancialPosition StatementOfFinancialPosition { get; set; } = null!;
}
