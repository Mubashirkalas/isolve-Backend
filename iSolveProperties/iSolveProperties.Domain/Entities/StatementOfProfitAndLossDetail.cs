using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class StatementOfProfitAndLossDetail
{
    public string SerialNo { get; set; } = null!;

    public byte CompId { get; set; }

    public int? Sno { get; set; }

    public string? Name { get; set; }

    public string? Glcodes { get; set; }

    public string? Classification { get; set; }

    public string? Remarks { get; set; }

    public virtual StatementOfProfitAndLoss StatementOfProfitAndLoss { get; set; } = null!;
}
