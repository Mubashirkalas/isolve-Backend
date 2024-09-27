using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EcrDetail
{
    public string Keys { get; set; } = null!;

    public int? Sno { get; set; }

    public string? PartyCode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? CylinderNo { get; set; }

    public bool? Status { get; set; }

    public int? Srno { get; set; }

    public byte? CompId { get; set; }

    public virtual EcrMain KeysNavigation { get; set; } = null!;
}
