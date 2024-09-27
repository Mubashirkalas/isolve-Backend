using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class MchLog
{
    public string MchCode { get; set; } = null!;

    public int LogSerial { get; set; }

    public string? MchDesc { get; set; }

    public string? MchNotes { get; set; }

    public string? SUser { get; set; }

    public DateTime? Opdate { get; set; }

    public int CompId { get; set; }

    public int? MchUserid { get; set; }

    public string? MchWorkstation { get; set; }

    public DateTime? MchDateModified { get; set; }

    public string? MchActionTaken { get; set; }
}
