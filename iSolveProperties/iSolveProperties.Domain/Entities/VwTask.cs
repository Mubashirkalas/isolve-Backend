using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTask
{
    public int SerialNo { get; set; }

    public string? TaskDescription { get; set; }

    public DateTime? TargetDate { get; set; }

    public DateTime? AssignDate { get; set; }

    public short? UserId { get; set; }

    public string? Step { get; set; }

    public string? LatestRemarks { get; set; }

    public short? AssignedByUserId { get; set; }

    public string? UserName { get; set; }

    public string? AssignedByUserName { get; set; }
}
