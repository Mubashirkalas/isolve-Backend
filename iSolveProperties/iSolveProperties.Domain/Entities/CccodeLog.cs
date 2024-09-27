using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class CccodeLog
{
    public string CcCode { get; set; } = null!;

    public int LogSerial { get; set; }

    public string? CcDesc { get; set; }

    public decimal? CcBudget { get; set; }

    public string? CcNotes { get; set; }

    public string? SUser { get; set; }

    public DateTime? OpDate { get; set; }

    public int CompId { get; set; }

    public int? CcUserid { get; set; }

    public string? CcWorkstation { get; set; }

    public DateTime? CcDateModified { get; set; }

    public string? CcActionTaken { get; set; }
}
