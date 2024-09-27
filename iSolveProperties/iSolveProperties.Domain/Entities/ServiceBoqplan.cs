using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class ServiceBoqplan
{
    public int SerialNo { get; set; }

    public byte CompId { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public short? ProjectId { get; set; }

    public short? BlockId { get; set; }
}
