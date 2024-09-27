using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwRebateDefinitionDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public string? RebateOffered { get; set; }

    public string? SalesPersonRebate { get; set; }
}
