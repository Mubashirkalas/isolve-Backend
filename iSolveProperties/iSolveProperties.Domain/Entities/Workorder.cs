using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class Workorder
{
    public string WoCode { get; set; } = null!;

    public string? WoDesc { get; set; }

    public DateTime? WoSdate { get; set; }

    public DateTime? WoEdate { get; set; }

    public string? WoNotes { get; set; }

    public string? SUser { get; set; }

    public DateTime? OpDate { get; set; }
}
