using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class AllotmentLetter
{
    public int Srno { get; set; }

    public byte CompId { get; set; }

    public int? SerialNo { get; set; }

    public short? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? BookingFormSrno { get; set; }

    public string? RefNo { get; set; }

    public DateOnly? ReceivedOn { get; set; }

    public string? ReceivedBy { get; set; }

    public string? Location { get; set; }

    public string? Remarks { get; set; }

    public short? SuserId { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public string? SworkStation { get; set; }

    public DateTime? McreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MuserName { get; set; }

    public string? MworkStation { get; set; }
}
