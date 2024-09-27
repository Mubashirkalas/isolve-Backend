using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemBoqplanDetail
{
    public string? ItemName { get; set; }

    public short Sno { get; set; }

    public string? GroupName { get; set; }

    public string Uom { get; set; } = null!;

    public string ItemCode { get; set; } = null!;

    public string GroupCode { get; set; } = null!;

    public int Qty { get; set; }

    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public short ProjectId { get; set; }

    public string? Project { get; set; }

    public short SubletId { get; set; }

    public string? SubProjectName { get; set; }

    public string? BlockName { get; set; }

    public short BlockId { get; set; }

    public DateOnly Date { get; set; }

    public short SubSegmentId { get; set; }
}
