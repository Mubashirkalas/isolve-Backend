using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ProjectSaleFingerPrint
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? FingerNo { get; set; }

    public string? Data { get; set; }

    public string? FormName { get; set; }

    public virtual ProjectSale ProjectSale { get; set; } = null!;
}
