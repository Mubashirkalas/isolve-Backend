using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AtcDetail
{
    public string Keys { get; set; } = null!;

    public int? Sno { get; set; }

    public string? PartyCode { get; set; }

    public int? EcrNo { get; set; }

    public DateOnly? EcrDate { get; set; }

    public string? CylinderNo { get; set; }

    public int? TestProcedureCode { get; set; }

    public double? Amount { get; set; }

    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public string? Year { get; set; }

    public virtual AtcMain KeysNavigation { get; set; } = null!;
}
