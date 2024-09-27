using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TaskHistory
{
    public int SerialNo { get; set; }

    public DateTime? WorkDate { get; set; }

    public string? Step { get; set; }

    public string? Remarks { get; set; }

    public int? TaskSerialNo { get; set; }

    public virtual Task? TaskSerialNoNavigation { get; set; }
}
