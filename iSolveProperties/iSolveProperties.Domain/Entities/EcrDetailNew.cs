using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class EcrDetailNew
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string Year { get; set; } = null!;

    public byte? SubSegmentId { get; set; }

    public string? EcrNo { get; set; }

    public short? Sno { get; set; }

    public string? PartyCode { get; set; }

    public string? ReferenceNo { get; set; }

    public string? Product { get; set; }

    public string? Ownership { get; set; }

    public string? Capacity { get; set; }

    public int? Total { get; set; }

    public int? Ok { get; set; }

    public int? SendtoTestShop { get; set; }

    public string? Status { get; set; }

    public virtual EcrMainNew EcrMainNew { get; set; } = null!;
}
