using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwInterBankTransferMain
{
    public string Srno { get; set; } = null!;

    public string? SerialNo { get; set; }

    public DateOnly? Date { get; set; }

    public byte? SubSegmentId { get; set; }

    public byte CompId { get; set; }

    public string FYear { get; set; } = null!;

    public string SubSegmentName { get; set; } = null!;
}
