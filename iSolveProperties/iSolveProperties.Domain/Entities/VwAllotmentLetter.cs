using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class VwAllotmentLetter
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public string SubSegmentName { get; set; } = null!;

    public DateOnly? Date { get; set; }

    public int? BookingFormSrno { get; set; }

    public string? BookingFormNo { get; set; }

    public string? RefNo { get; set; }

    public DateOnly? ReceivedOn { get; set; }

    public string? ReceivedBy { get; set; }

    public string? Location { get; set; }

    public string? Remarks { get; set; }
}
