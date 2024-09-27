using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwTransactionlog
{
    public string? DocumentNo { get; set; }

    public DateOnly? DocumentDate { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentNarration { get; set; }

    public short? UserId { get; set; }

    public short? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? UserName { get; set; }
}
