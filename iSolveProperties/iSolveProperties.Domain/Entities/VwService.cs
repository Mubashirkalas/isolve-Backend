using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwService
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public string? Name { get; set; }
}
