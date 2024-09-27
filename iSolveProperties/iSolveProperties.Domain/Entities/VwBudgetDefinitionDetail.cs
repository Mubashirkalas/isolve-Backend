using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBudgetDefinitionDetail
{
    public short? Sno { get; set; }

    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public string? HeadCode { get; set; }

    public string Head { get; set; } = null!;

    public int? July { get; set; }

    public int? Aug { get; set; }

    public int? Sep { get; set; }

    public int? Oct { get; set; }

    public int? Nov { get; set; }

    public int? Dec { get; set; }

    public int? Jan { get; set; }
}
