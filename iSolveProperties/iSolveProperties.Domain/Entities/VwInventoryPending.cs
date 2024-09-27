using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInventoryPending
{
    public int? Grnno { get; set; }

    public bool? Approved { get; set; }

    public byte CompId { get; set; }

    public DateOnly? Grndate { get; set; }

    public string Year { get; set; } = null!;

    public long SerialNo { get; set; }

    public string? Status { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Bpcode { get; set; }

    public string? BusinessPartnersName { get; set; }

    public string? Type { get; set; }

    public int? Srno { get; set; }
}
