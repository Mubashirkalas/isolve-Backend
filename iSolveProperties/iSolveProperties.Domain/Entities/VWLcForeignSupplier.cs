using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VWLcForeignSupplier
{
    public byte CompId { get; set; }

    public string? LcMargin { get; set; }

    public string? SalesTax { get; set; }

    public string? IncomeTax { get; set; }

    public string? LcMarginDesc { get; set; }

    public string? SalesTaxDesc { get; set; }

    public string? IncomeTaxDesc { get; set; }
}
