using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class RebateDefinitionDetail
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? Sno { get; set; }

    public string? RebateOffered { get; set; }

    public string? SalesPersonRebate { get; set; }

    public virtual RebateDefinition RebateDefinition { get; set; } = null!;
}
