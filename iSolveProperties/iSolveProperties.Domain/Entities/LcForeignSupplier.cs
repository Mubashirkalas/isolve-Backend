using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class LcForeignSupplier
{
    public byte CompId { get; set; }

    public string? LcMargin { get; set; }

    public string? SalesTax { get; set; }

    public string? IncomeTax { get; set; }
}
