using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class BookingConfirmationLetter
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public short SubSegmentId { get; set; }

    public int SerialNo { get; set; }

    public string? ProjectId { get; set; }

    public DateOnly? Date { get; set; }

    public virtual Companysetup Comp { get; set; } = null!;

    public virtual SubSegment SubSegment { get; set; } = null!;
}
