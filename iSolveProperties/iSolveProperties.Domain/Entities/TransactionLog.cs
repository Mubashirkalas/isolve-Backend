using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class TransactionLog
{
    public string? DocumentNo { get; set; }

    public DateTime? DocumentDate { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentNarration { get; set; }

    public short? UserId { get; set; }

    public short? SubSegmentId { get; set; }
}
