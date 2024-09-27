using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwItemBoqplan
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public short? ProjectId { get; set; }

    public string? Project { get; set; }

    public short? BlockId { get; set; }

    public string? BlockName { get; set; }

    public short? SubletId { get; set; }

    public string? SubProjectName { get; set; }
}
