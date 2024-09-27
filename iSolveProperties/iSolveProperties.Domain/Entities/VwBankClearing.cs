using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwBankClearing
{
    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public string? SubSegmentName { get; set; }

    public string? AccountNo { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;
}
