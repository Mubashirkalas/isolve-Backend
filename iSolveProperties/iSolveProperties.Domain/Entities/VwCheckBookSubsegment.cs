using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwCheckBookSubsegment
{
    public string? ChequebookNo { get; set; }

    public string? ChequeFrom { get; set; }

    public string? ChequeTo { get; set; }

    public byte? CompId { get; set; }

    public string? FYear { get; set; }

    public string? Srno { get; set; }

    public byte? SubSegmentId { get; set; }
}
