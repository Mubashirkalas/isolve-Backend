using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class PartyCreditLimit
{
    public string? Bpcode { get; set; }

    public short? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public double? Debit { get; set; }

    public double? Credit { get; set; }

    public byte? CompId { get; set; }

    public double? CreditLimit { get; set; }

    public string? RecoveryDay { get; set; }
}
