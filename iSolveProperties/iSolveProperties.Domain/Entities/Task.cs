using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Task
{
    public int SerialNo { get; set; }

    public DateTime? AssignDate { get; set; }

    public short? UserId { get; set; }

    public string? TaskDescription { get; set; }

    public DateTime? TargetDate { get; set; }

    public string? Step { get; set; }

    public string? LatestRemarks { get; set; }

    public short? AssignedByUserId { get; set; }

    public virtual ICollection<TaskHistory> TaskHistories { get; set; } = new List<TaskHistory>();
}
