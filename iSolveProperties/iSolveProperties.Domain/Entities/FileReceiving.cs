using System;
using System.Collections.Generic;

namespace iSolveProperties.Domain.Entities;

public partial class FileReceiving
{
    public string Srno { get; set; } = null!;

    public byte CompId { get; set; }

    public string FinancialYear { get; set; } = null!;

    public string? SerialNo { get; set; }

    public byte? SubSegmentId { get; set; }

    public DateOnly? Date { get; set; }

    public int? BookingFormSrno { get; set; }

    public string? BookingFormNo { get; set; }

    public string? FileNo { get; set; }

    public DateOnly? IssueDate { get; set; }

    public short? SuserId { get; set; }

    public string? SworkStation { get; set; }

    public string? SuserName { get; set; }

    public DateTime? ScreationDate { get; set; }

    public short? MuserId { get; set; }

    public string? MworkStation { get; set; }

    public string? MuserName { get; set; }

    public DateTime? McreationDate { get; set; }

    public string? PlotNo { get; set; }

    public DateOnly? FileDate { get; set; }

    public string? Location { get; set; }

    public short? SubSegmentFrom { get; set; }

    public short? SubSegmentTo { get; set; }

    public virtual BookingForm? BookingForm { get; set; }
}
